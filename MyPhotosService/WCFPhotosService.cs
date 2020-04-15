using MyPhotosInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Script.Serialization;
using System.Web.UI;

namespace MyPhotosService {
    public class WCFPhotosService : IWCFPhotosService { 
        public List<FileData> GetFileDatas(string type = "", string date = "", string tag = "") {
            Console.WriteLine("GetFileDatas was called");

            List<FileData> result = new List<FileData>();

            try {
                using (MyPhotosEntities database = new MyPhotosEntities()) {
                    foreach ( var file in database.Files) {
                        if ( file.deleted == "y") {
                            continue;
                        }

                        if (type != "") {
                            if (file.type.ToString() != type) {
                                continue;
                            }
                        }

                        if (date != "") {
                            if (!file.date.ToString().Contains(date)) {
                                continue;
                            }
                        }

                        if (tag != "") {
                            bool print = false;

                            foreach (Tag t in file.Tags) {
                                if (t.tag.ToString() == tag) {
                                    print = true;
                                }
                            }

                            if (print == false) {
                                continue;
                            }
                        }

                        List<TagData> tags = new List<TagData>();

                        foreach ( Tag t in file.Tags) {
                            tags.Add(new TagData(t.tag));
                        }

                        result.Add(new FileData(file.id, file.date, file.type, file.path, tags));
                    }
                }

            }
            catch (Exception e) {
                Console.WriteLine(e);
            }

            return result;
        }

        public bool AddFile(FileData fileData) {
            Console.WriteLine("AddFile was called");

            try {
                var dbContext = new MyPhotosEntities();

                var result = dbContext.Files.Add(new File() {
                    id = fileData.id,
                    type = fileData.type,
                    path = fileData.path,
                    deleted = "n",
                    date = fileData.date
                });

                foreach ( var tag in fileData.Tags) {
                    dbContext.Tags.Add(new Tag() {
                        idFile = result.id,
                        tag = tag.tag
                    }) ;
                }

                dbContext.SaveChanges();

                return true;
            } catch(Exception e) {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool EditFile(int idFile, List<TagData> tags) {
            Console.WriteLine("EditFile was called");

            try {
                FileData file = GetById(idFile);

                file.id = idFile;

                var deleted = DeleteFile(idFile);

                if ( deleted == false) {
                    return false;
                }

                file.Tags = tags;

                AddFile(file);

                return true;
            } catch(Exception e) {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool DeleteFile(int idFile) {
            Console.WriteLine("DeleteFile was called");

            try {
                var dbContext = new MyPhotosEntities();

                dbContext.Files.Find(idFile).deleted = "y";

                dbContext.SaveChanges();

                return true;
            } catch(Exception e) {
                Console.WriteLine(e);
                return false;
            }
        }

        public FileData GetById(int idFile) {
            Console.WriteLine("GetById was called");

            try {
                var dbContext = new MyPhotosEntities();

                File f = dbContext.Files.Find(idFile);

                if ( f.deleted == "y") {
                    return new FileData();
                }

                List<TagData> tags = new List<TagData>();

                foreach ( var t in f.Tags) {
                    tags.Add(new TagData(t.tag));
                }

                FileData file = new FileData(f.id, f.date, f.type, f.path, tags);

                return file;
            }
            catch (Exception e) {
                Console.WriteLine(e);
                return new FileData();
            }
        }
    }
}
