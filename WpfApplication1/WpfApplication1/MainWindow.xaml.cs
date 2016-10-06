using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    public interface ILibrary
    {
        void MakeInformation();
        void ModifyInformation();
        void Search();
        void Selection();
    }

    public class BL : ILibrary
    {
        public void MakeInformation()
        {
            // ...
        }

        public void ModifyInformation()
        {
            // ..
        }

        public void Search()
        {
            // ..
        }

        public void Selection()
        {
            // ..
        }
    }

    public class Library
    {
        public List<Section> sections { get; set; }

        public Library(List<Section> sections)
        {
            this.sections = sections;
        }
    }
    public class Book
    {
        private string author;
        private string name;
        private string publication;
        private int year_of_publication;
        private int number_of_pages;

        private SubjectiveEstimation estimation;

        public Book() { }
        public Book(string a, string n, string p, int year, int num, SubjectiveEstimation est)
        {
            this.author = a;
            this.name = n;
            this.publication = p;
            this.year_of_publication = year;
            this.number_of_pages = num;
            this.estimation = est;

        }

        public string Author
        {
            get; set;
        }

        public string Name
        {
            get; set;
        }

        public string Publication
        {
            get; set;
        }

        public int Year_of_publication
        {
            get; set;
        }

        public int Number_of_pages
        {
            get; set;
        }
    }

    public interface ISection
    {
        int Count();
    }

    public abstract class Section : ISection
    {
        private List<Book> books;
        private string NameOfSection;
        public List<Book> Books
        {
            get
            {
                return this.books;
            }
            set
            {
                this.books = value;
            }
        }

        public string Name
        {
            get
            {
                return this.NameOfSection;
            }
            set
            {
                this.NameOfSection = value;
            }
        }

        public Section() { }

        public Section(string name, List<Book> books)
        {
            this.Name = name;
            this.Books = books;
        }

        public int Count()
        {
            return this.Books.Count();
        }
    }

    public class Specialized : Section
    {
        //some additional features 
        public Specialized(string name, List<Book> books) : base(name, books) { }
    }
    public class Detective : Section
    {
        //some additional features 
        public Detective(string name, List<Book> books) : base(name, books) { }
    }
    public class TextBook : Section
    {
        //some additional features 
        public TextBook(string name, List<Book> books) : base(name, books) { }
    }

    public class SubjectiveEstimation
    {
        private string origin;
        private bool availability;
        private bool worth;
        private string recommendation;

        public SubjectiveEstimation() { }
        public SubjectiveEstimation(string o, bool a, bool w, string r)
        {
            this.origin = o;
            this.availability = a;
            this.worth = w;
            this.recommendation = r;
        }
    }


    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
