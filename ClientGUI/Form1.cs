using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using MyPhotosInterfaces;
using System.Diagnostics;


namespace ClientGUI {
    public partial class Form1 : Form {
        public void fillTable(string type = "", string date = "", string tag = "") {
            ChannelFactory<IWCFPhotosService> channelFactory =
                new ChannelFactory<IWCFPhotosService>("PhotosServiceEndpoint");

            IWCFPhotosService proxy = channelFactory.CreateChannel();

            infoListView.Items.Clear();

            var files = proxy.GetFileDatas(type, date, tag);

            foreach ( FileData file in files ) {
                string tags = String.Join(", ", file.Tags.Select(i => i.tag.ToString()).ToArray());

                ListViewItem item = new ListViewItem(file.id.ToString());
                item.SubItems.Add(file.path.ToString());
                item.SubItems.Add(file.date.ToString());
                item.SubItems.Add(file.type.ToString());
                item.SubItems.Add(tags.ToString());

                infoListView.Items.Add(item);
            }
        }

        public Form1() {
            InitializeComponent();
            fillTable("", "", "");
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void searchButton_Click_1(object sender, EventArgs e) {
            DateTime dateTime = new DateTime();
            DateTime.TryParse(dateTextBox.Text.ToString(), out dateTime);

            var date = dateTime.ToString().Split(' ')[0];
            date = date == "1/1/0001" ? "" : date;
            var tag = searchTextBox.Text.Split(',')[0].ToString();
            tag = tag == "Search by tag" ? "" : tag;
            var type = searchComboBox.Text.ToString() == "all" ? "" : searchComboBox.Text.ToString();

            fillTable(type, date, tag);
        }

        private void openButton_Click_1(object sender, EventArgs e) {
            if (infoListView.SelectedItems.Count == 0) {
                MessageBox.Show("Please select an id");
                return;
            }

            ListViewItem selectedItem = infoListView.SelectedItems[0];

            string mypath = selectedItem.SubItems[1].Text.ToString();

            string[] photoExtensions = { "jpg", "jpeg", "png", "orf" };

            if (photoExtensions.Contains(mypath.Split('.')[1])) {
                pictureBox.Image = new Bitmap(mypath);
            }
            else {
                Process.Start(mypath);
            }

            ChannelFactory<IWCFPhotosService> channelFactory =
                new ChannelFactory<IWCFPhotosService>("PhotosServiceEndpoint");

            IWCFPhotosService proxy = channelFactory.CreateChannel();

            FileData file = proxy.GetById(int.Parse(infoListView.SelectedItems[0].SubItems[0].Text.ToString()));

            currentTags.Text = String.Join(", ", file.Tags.Select(i => i.tag.ToString()).ToArray());
        }

        private void deleteButton_Click_1(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this file?", "", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes) {
                try {
                    ChannelFactory<IWCFPhotosService> channelFactory =
                new ChannelFactory<IWCFPhotosService>("PhotosServiceEndpoint");

                    IWCFPhotosService proxy = channelFactory.CreateChannel();

                    int id = int.Parse(infoListView.SelectedItems[0].SubItems[0].Text.ToString());

                    proxy.DeleteFile(id);

                    fillTable("", "", "");
                } catch {
                    MessageBox.Show("Something went wrong. Please make sure that you clicked the id of the file you want to delete.");
                }
            }
        }

        private void selectFileButton_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog {
                InitialDirectory = @"C:\",
                Title = "Browse Photos/Videos",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "jpg",
                Filter = "Photos (*.jpeg;*.jpg;*.png;*.orf)|*.jpeg;*.jpg;*.png;*.orf|Videos (*.mp4;*.avi;*.flv)|*.mp4;*.avi;*.flv",
            };

            if (ofd.ShowDialog() == DialogResult.OK) {
                pathTextBox.Text = ofd.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            var path = pathTextBox.Text;

            if (path == "") {
                MessageBox.Show("Please select a file", "No file selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var tags = tagsTextBox.Text.Split(',');

            string[] photoExtensions = { "jpg", "jpeg", "png", "orf" };

            var type = (photoExtensions.Contains(path.Split('.')[1])) ? "photo" : "video";

            List<TagData> tagsList = new List<TagData>();

            foreach ( var t in tags) {
                if ( t != "") {
                    tagsList.Add(new TagData(t));
                }
            }

            FileData file = new FileData(0, DateTime.Now, type, path, tagsList, "n");

            ChannelFactory<IWCFPhotosService> channelFactory =
                new ChannelFactory<IWCFPhotosService>("PhotosServiceEndpoint");

            IWCFPhotosService proxy = channelFactory.CreateChannel();

            bool result = proxy.AddFile(file);

            if ( result == true) {
                MessageBox.Show("File added");
            }
            else {
                MessageBox.Show("Something went wrong");
            }

            fillTable("", "", "");
        }

        private void editButton_Click(object sender, EventArgs e) {
            List<TagData> newTags = new List<TagData>();

            var tags = currentTags.Text.Split(',');

            foreach ( var t in tags) {
                if ( t != "") {
                    newTags.Add(new TagData(t));
                }
            }

            ChannelFactory<IWCFPhotosService> channelFactory =
                new ChannelFactory<IWCFPhotosService>("PhotosServiceEndpoint");

            IWCFPhotosService proxy = channelFactory.CreateChannel();

            bool done = proxy.EditFile(int.Parse(infoListView.SelectedItems[0].SubItems[0].Text.ToString()), newTags);

            if ( done == true) {
                MessageBox.Show("Edit done");
            } else {
                MessageBox.Show("Edit failed");
            }

            fillTable("", "", "");
        }
    }
}
