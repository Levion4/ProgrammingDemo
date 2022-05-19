using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model.Classes;
using Programming.Model.Enums;

namespace Programming.View.Controls
{
    public partial class MoviesInfoControl : UserControl
    {
        private Movie[] _movie;

        private Movie _currentMovie = new Movie();

        private string[] _movies = new string[] {"Captain America: The First Avenger",
            "Captain Marvel", "Iron Man", "Iron Man 2", "The Incredible Hulk",
            "Thor", "The Avengers", "Shang-Chi and the Legend of the Ten Rings",
            "Iron Man 3", "Thor: The Dark World", "Captain America: The Winter Soldier",
            "Guardians of the Galaxy", "Guardians of the Galaxy 2",
            "Avengers: Age of Ultron", "Ant-Man", "Captain America: Civil War",
            "Black Widow", "Black Panther", "Spider-Man: Homecoming", "Doctor Strange",
            "Thor: Ragnarok", "Avengers: Infinity War", "Ant-Man and The Wasp",
            "Avengers: Endgame", "Spider-Man: Far From Home", "Eternals",
            "Spider-Man: No Way Home", "Doctor Strange in the Multiverse of Madness",
            "Thor: Love and Thunder", "Black Panther: Wakanda Forever" };

        public MoviesInfoControl()
        {
            InitializeComponent();
            InitMovies();
            MoviesListBox.SelectedIndex = 0;
        }

        private void InitMovies()
        {
            _movie = new Movie[5];
            Random random = new Random();
            int lengthGenre = Enum.GetNames(typeof(Genre)).Length;
            for (var i = 0; i < 5; i++)
            {
                _movie[i] = new Movie(
                    random.Next(1, 421),
                    random.Next(1900, DateTime.Now.Year),
                    Math.Round(random.NextDouble() * 10, 1),
                    _movies[random.Next(0, _movies.Length)],
                    ((Genre)random.Next(lengthGenre)).ToString());
                MoviesListBox.Items.Add($"Movie {i + 1}");
            }
        }

        private int FindMovieWithMaxRating(Model.Classes.Movie[] movies)
        {
            var maxIndex = 0;
            var maxValues = movies[maxIndex].Rating;
            for (var i = 0; i < movies.Length; i++)
            {
                if (movies[i].Rating > maxValues)
                {
                    maxValues = movies[i].Rating;
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentMovie = _movie[MoviesListBox.SelectedIndex];
            TitleTextBox.Text = _currentMovie.Title;
            GenreTextBox.Text = _currentMovie.Genre;
            DurationInMinutesTextBox.Text = _currentMovie.DurationInMinutes.ToString();
            YearOfReleaseTextBox.Text = _currentMovie.YearOfRelease.ToString();
            RatingTextBox.Text = _currentMovie.Rating.ToString();
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Title = TitleTextBox.Text;
                TitleTextBox.BackColor = AppColors.NormalColor;
                ToolTip.SetToolTip(TitleTextBox, "");
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(TitleTextBox, exception.Message);
                TitleTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Genre = GenreTextBox.Text;
                GenreTextBox.BackColor = AppColors.NormalColor;
                ToolTip.SetToolTip(GenreTextBox, "");
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(GenreTextBox, exception.Message);
                GenreTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void DurationInMinutesTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.DurationInMinutes = Convert.ToInt32(DurationInMinutesTextBox.Text);
                DurationInMinutesTextBox.BackColor = AppColors.NormalColor;
                ToolTip.SetToolTip(DurationInMinutesTextBox, "");
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(DurationInMinutesTextBox, exception.Message);
                DurationInMinutesTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void YearOfReleaseTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.YearOfRelease = Convert.ToInt32(YearOfReleaseTextBox.Text);
                YearOfReleaseTextBox.BackColor = AppColors.NormalColor;
                ToolTip.SetToolTip(YearOfReleaseTextBox, "");
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(YearOfReleaseTextBox, exception.Message);
                YearOfReleaseTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Rating = Convert.ToDouble(RatingTextBox.Text);
                RatingTextBox.BackColor = AppColors.NormalColor;
                ToolTip.SetToolTip(RatingTextBox, "");
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(RatingTextBox, exception.Message);
                RatingTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
        }

        private void MoviesButton_Click(object sender, EventArgs e)
        {
            MoviesListBox.SelectedIndex = FindMovieWithMaxRating(_movie);
        }
    }
}
