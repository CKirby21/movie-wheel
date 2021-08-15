using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MovieWheel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //private List<string> _movies = new List<string>();
        ////private List<Color> _colors = new List<Color>() { Color.Red, Color.Orange, Color.Green, Color.Gray, Color.Blue, Color.Violet, Color.Purple };
        //private string _baseUrl = "http://www.omdbapi.com/?apikey=c15b00f2&t=";
        //private string _filePath = Environment.CurrentDirectory + "\\movies.txt";

        //#region Buttons and Timers
        //private void MoviePickerForm_Load(object sender, EventArgs e)
        //{
        //    HideResultScreen();
        //    if (File.Exists(_filePath))
        //        LoadMoviesFromFile();
        //    else
        //        File.WriteAllText(_filePath, "");
        //}

        //private void buttonSpinner_Click(object sender, EventArgs e)
        //{
        //    if (timerRotation.Enabled)
        //    {
        //        labelMovieName.Text = GetRandomMovie();
        //        labelMovieName.ForeColor = GetRandomColor();
        //        PopulateResultScreen(labelMovieName.Text);
        //        ShowResultScreen();
        //        timerRotation.Enabled = false;
        //    }
        //    else
        //    {
        //        HideResultScreen();
        //        timerRotation.Enabled = true;
        //    }
        //}

        //private void buttonRemove_Click(object sender, EventArgs e)
        //{
        //    if (String.IsNullOrEmpty(textBoxMovies.Text))
        //        return;

        //    string[] moviesToRemove = textBoxMovies.Text.Split(',');
        //    foreach (string movie in moviesToRemove)
        //    {
        //        _movies.Remove(movie);
        //    }
        //    File.WriteAllText(_filePath, BuildMoviesCSV());
        //    textBoxMovies.Clear();
        //}

        //private void buttonAdd_Click(object sender, EventArgs e)
        //{
        //    if (String.IsNullOrEmpty(textBoxMovies.Text))
        //        return;

        //    string[] moviesToAdd = textBoxMovies.Text.Split(',');
        //    foreach (string movie in moviesToAdd)
        //    {
        //        _movies.Add(movie);
        //    }
        //    File.WriteAllText(_filePath, BuildMoviesCSV());
        //    textBoxMovies.Clear();
        //}

        //private void timerRotation_Tick(object sender, EventArgs e)
        //{
        //    Image imageToRotate = circlePictureBox1.Image;
        //    imageToRotate.RotateFlip(RotateFlipType.Rotate90FlipNone);
        //    circlePictureBox1.Image = imageToRotate;
        //}
        //#endregion

        //#region Methods

        //private string GetRandomMovie()
        //{
        //    int numberOfMovies = _movies.Count;
        //    if (numberOfMovies == 0)
        //        return "";
        //    Random r = new Random();
        //    int randomIndex = r.Next(numberOfMovies);
        //    return _movies[randomIndex];
        //}

        //private Color GetRandomColor()
        //{
        //    Random r = new Random();
        //    int randomIndex = r.Next(_colors.Count);
        //    return _colors[randomIndex];
        //}

        //public void PopulateResultScreen(string movieName)
        //{
        //    string url = _baseUrl + movieName.Trim();

        //    using (WebClient wc = new WebClient())
        //    {
        //        var json = wc.DownloadString(url);
        //        JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
        //        ImdbEntity movieDetails = new ImdbEntity();
        //        movieDetails = jsonSerializer.Deserialize<ImdbEntity>(json);
        //        if (movieDetails.Response == "True")
        //        {
        //            labelYear.Text = movieDetails.Year;
        //            labelPlot.Text = movieDetails.Plot;
        //            labelRating.Text = movieDetails.imdbRating + " / 10";
        //            labelActors.Text = movieDetails.Actors;
        //        }
        //        else
        //        {
        //            labelPlot.Text = "Movie not Found!!!";
        //        }
        //    }
        //}

        //private void HideResultScreen()
        //{
        //    //this.Width = 360;
        //    //foreach (Control c in this.Controls)
        //    //{
        //    //    if (c.Tag != null && c.Tag.Equals("result"))
        //    //    {
        //    //        c.Visible = false;
        //    //    }
        //    //}
        //}

        //private void ShowResultScreen()
        //{
        //    //this.Width = 700;
        //    //foreach (Control c in this.Controls)
        //    //{
        //    //    if (c.Tag != null && c.Tag.Equals("result"))
        //    //    {
        //    //        c.Visible = true;
        //    //    }
        //    //}
        //}

        //private string BuildMoviesCSV()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    foreach (var movie in _movies)
        //    {
        //        sb.Append(movie + ",");
        //    }
        //    return sb.ToString().TrimEnd(',');
        //}

        //private void LoadMoviesFromFile()
        //{
        //    if (!File.Exists(_filePath))
        //        return;

        //    string lineIn;
        //    using (FileStream fs = new FileStream(_filePath, FileMode.Open, FileAccess.Read))
        //    using (StreamReader inputReader = new StreamReader(fs))
        //    {
        //        if ((lineIn = inputReader.ReadLine()) != null)
        //        {
        //            string[] moviesArray = lineIn.Split(',');
        //            _movies = moviesArray.ToList();
        //        }
        //    }
        //}

        //#endregion
    }
}
