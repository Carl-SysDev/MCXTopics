using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MCXTopics.Classes;
using OfficeOpenXml;

namespace MCXTopics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Topics> topics;
        public string SearchResultCount { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            //GET THE PATH OF UPLODED FILES
            string uploadDirectory = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "uploads");

            //CREATE FOLDER UPLOADS IF IT DOESN'T EXIST IN THE DIRECTORY
            if (!System.IO.Directory.Exists(uploadDirectory))
            {
                System.IO.Directory.CreateDirectory(uploadDirectory);
            }

            //GET THE EXCEL FILES
            string[] excelFiles = System.IO.Directory.GetFiles(uploadDirectory, "*.xlsx", System.IO.SearchOption.AllDirectories);

            //SHOWING THE ALL UPLOADED EXCEL FILES IN FILEUPLOADSLISTBOX
            foreach (string file in excelFiles)
            {
                FileUploads.Items.Add(System.IO.Path.GetFileName(file));
            }

            //EXTRACT DATA FROM EXCEL
            var topics = new List<Topics>();

            //READ DATA FROM EXCEL FILES AND POPULATE SearchResultsListBox
            foreach (string file in excelFiles)
            {
                using (var package = new ExcelPackage(file))
                {
                    var workbook = package.Workbook;

                    // Iterate over all worksheets in the workbook
                    foreach (ExcelWorksheet worksheet in workbook.Worksheets)
                    {
                        //CHECK IF THE WORKSHEET HAS LESS OR MORE THAN 6 COLUMNS
                        if (worksheet.Dimension.End.Column > 6)
                        {
                            MessageBox.Show("Please Upload Worksheet with this Column format:\nCompanyName|SecNum|LicenseNumber|DateRegistered|TaxpayerName|Violation", "Invalid Worksheet Format", MessageBoxButton.OK, MessageBoxImage.Error);
                            continue;
                        }

                        for (int row = 2; row <= worksheet.Dimension.End.Row; row++) //START FROM ROW 2, ASSUMING ROW 1 IS THE HEADER
                        {
                            //IF CELL IS NULL, ASSIGN NONE USING TERNARY
                            var code = worksheet.Cells[row, 1].Value?.ToString() ?? "NONE";
                            var topic = worksheet.Cells[row, 2].Value?.ToString() ?? "NONE";
                            var description = worksheet.Cells[row, 3].Value?.ToString() ?? "NONE";
                            var howToUse = worksheet.Cells[row, 4].Value?.ToString() ?? "NONE";
                            var whenToUse = worksheet.Cells[row, 5].Value?.ToString() ?? "NONE";
                            var others = worksheet.Cells[row, 6].Value?.ToString() ?? "NONE";

                            topics.Add(new Topics(code, topic, description, howToUse, whenToUse, others));
                        }
                    }
                }
            }
            //PASS THE EXTRACTED DATA TO THE GLOBAL COMPANIES LIST
            this.topics = topics;

            //DISPLAY ALL COMPANY NAMES IN SEARCH LISTBOX
            SearchResultsListBox.ItemsSource = topics;

            //GET HOW MANT SEARCH FOUND AND CONVERT IT TO StrING
            SearchResultCount = topics.Count.ToString();

            ResultFound.Text = "RESULTS: " + SearchResultCount;
        }

        // SEARCHBOX RESULTS
        private void SearchResultsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Topics selectedTopic = (Topics)SearchResultsListBox.SelectedItem;
            if (selectedTopic != null)
            {
                ShowDetails showDetails = new ShowDetails();
                showDetails.TopicTextBlock.Text = selectedTopic.Topic;
                showDetails.DescriptionTextBlock.Text = selectedTopic.Description;
                showDetails.ShowDialog();
            }
        }

        //FILES UPLOADED
        private void FileUploads_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show("You have selected: " + FileUploads.SelectedItem);
        }

        //RECOMMENDED TOPICS
        private void RecommedTopics_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        //PLACEHOLDER IF CLICK
        private void SearchBox_GotFocus(object sender, RoutedEventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox.Text == "Search...")
            {
                textBox.Text = string.Empty;
                textBox.Foreground = Brushes.Black; //CHANGE TEXT COLOR TO BLACK WHEN USER TYPE
            }
        }

        //PLACEHOLDER IF LOSE FOCUS
        private void SearchBox_LostFocus(object sender, RoutedEventArgs e)
        {
            var textBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Search...";
                textBox.Foreground = Brushes.Gray;
            }
        }

        //EXIT HANDLER
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }

        //UPLOAD HANDLER
        private void UploadButton_Click(object sender, RoutedEventArgs e)
        {
            // Set the license context para to sa na install na package
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            var dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.Filter = "Excel Files (*.xls, *.xlsx, *.xlsm, *.xlsb, *.xltx)|*.xls;*.xlsx;*.xlsm;*.xlsb;*.xltx";
            dialog.Multiselect = true; //MAKE YOU UPLOAD MORE THAN 1 FILE

            if (dialog.ShowDialog() == true)
            {
                string[] selectedFiles = dialog.FileNames;

                string uploadDirectory = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "uploads");

                var topics = new List<Topics>();

                // Read the Excel files and extract data
                foreach (string file in selectedFiles)
                {
                    using (var package = new ExcelPackage(file))
                    {
                        var workbook = package.Workbook;

                        // Iterate over all worksheets in the workbook
                        foreach (ExcelWorksheet worksheet in workbook.Worksheets)
                        {
                            //CHECK IF THE WORKSHEET HAS LESS OR MORE THAN 6 COLUMNS
                            if (worksheet.Dimension.End.Column > 6)
                            {
                                MessageBox.Show("Please Upload Worksheet with this Column format:\nCompanyName|SecNum|LicenseNumber|DateRegistered|TaxpayerName|Violation", "Invalid Worksheet Format", MessageBoxButton.OK, MessageBoxImage.Error);
                                continue;
                            }

                            //EXTRACT DATA FROM EXCEL
                            for (int row = 2; row <= worksheet.Dimension.End.Row; row++) //START FROM ROW 2, ASSUMING ROW 1 IS THE HEADER
                            {
                                //IF CELL IS NULL, ASSIGN NONE USING TERNARY
                                var code = worksheet.Cells[row, 1].Value?.ToString() ?? "NONE";
                                var topic = worksheet.Cells[row, 2].Value?.ToString() ?? "NONE";
                                var description = worksheet.Cells[row, 3].Value?.ToString() ?? "NONE";
                                var howToUse = worksheet.Cells[row, 4].Value?.ToString() ?? "NONE";
                                var whenToUse = worksheet.Cells[row, 5].Value?.ToString() ?? "NONE";
                                var others = worksheet.Cells[row, 6].Value?.ToString() ?? "NONE";

                                topics.Add(new Topics(code, topic, description, howToUse, whenToUse, others));
                            }
                        }
                    }

                    //COPY THE FILE OR UPLOAD THE FILE IN MY DIRECTORY
                    string fileName = System.IO.Path.GetFileName(file);
                    string destinationPath = System.IO.Path.Combine(uploadDirectory, fileName);

                    System.IO.File.Copy(file, destinationPath, true); //OVERWRITE FILE IF EXISTS

                    //SHOW ALL UPLOADED FILES IN UPLOADS LISTBOX
                    FileUploads.Items.Add(fileName);
                }

                //PASS THE EXTRACTED DATA TO THE GLOBAL COMPANIES LIST
                this.topics = topics;

                //MESSAGE UPLOAD SUCESSFULLY
                MessageBox.Show("Upload successful.", "Upload", MessageBoxButton.OK, MessageBoxImage.Information);

                //DISPLAY ALL COMPANY NAMES IN SEARCH LISTBOX
                SearchResultsListBox.ItemsSource = topics;

                //GET HOW MANT SEARCH FOUND AND CONVERT IT TO StrING
                SearchResultCount = topics.Count.ToString();

                ResultFound.Text = "RESULTS: " + SearchResultCount;
            }
        }

        //SEARCH HANDLER
        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string searchText = SearchBox.Text;

            if (topics == null || topics.Count == 0)
            {
                MessageBox.Show("Please select or upload data set first.", "No Data Uploaded", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            //UPDATE VALUE OF SEARCH BASED ON HEADER
            //CompanyHeader.Text = "SEARCH: " + searchText;

            //INSTANTIATE THE SEARCH CLASS
            Search search = new Search(searchText);

            //CALL THE SEARCHCOMPANIES METHOD IN THE SEARCH CLASS
            List<Topics> searchResults = search.SearchTopics(topics);

            //GET HOW MANT SEARCH FOUND AND CONVERT IT TO StrING
            SearchResultCount = searchResults.Count.ToString();

            ResultFound.Text = "RESULTS: " + SearchResultCount;

            //DISPLAY THE SEARCH RESULTS
            SearchResultsListBox.ItemsSource = searchResults;

            //CHECK IF NO RESULT FOUND SHOW TEXTBOX N0 RESULT FOUND
            if (SearchResultsListBox.Items.Count == 0)
            {
                MessageBox.Show("No results found for your search.", "No Results Found", MessageBoxButton.OK, MessageBoxImage.Information);
                //IF NO RESUT FOUND STILL SHOW ALL AVAILABLE COMPANIES
                SearchResultsListBox.ItemsSource = topics;
            }
        }

        private void clearSearch_Click(object sender, RoutedEventArgs e)
        {
            SearchBox.Clear();
            SearchBox.Text = "Search...";
            SearchBox.Foreground = Brushes.DarkSlateGray;
        }
    }
}