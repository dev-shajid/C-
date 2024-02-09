using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaManagement
{
    public interface Imedia //interface no need to implement the method
    {
        void displayinfo();//abstract method

       
    }
    public class Media<T>:Imedia
    {
        public int id { get; set; }//feild
        public T title {  get; set; }
       
        public int releasedate { get; set; }

        public int prise { get; set; }
        public string Type { get; set; }
        public Media(int id,T title, int prise, int releasedate)//parametrize constructor
        {
            this.id = id;
            this.title = title;
            this.prise = prise;
            this.releasedate = releasedate;
        }
       
        public void displayinfo()
        {
            Console.WriteLine($"Title :{title}\nreleasedate :{releasedate}");
        }

        /* public  virtual IEnumerable<Books>  getbyyear(List<Books> bok,int year)
        {
            return bok.Where(book => book.releasedate>year);//filtering from which yeasr i want to get the book
        } */

       
    }



   public partial class Books : Media<string>//cant pass multip,le type generic instance have one type and alll are same
    {//inherited from media class
        public string auther { get; set; }
       
        public Books (int id,string title,int releasedate,int prise,string auther):base (id,title, prise,releasedate)//base class constructor
        {
            this.auther = auther;
            //Type= type;
        }
       
        public void displayinfo(string auther)
        {
            Console.WriteLine($"auther : {auther}");
        }

    }

    public partial class CDs : Media<string>//cant pass multip,le type generic instance have one type
    {
        public string artist { get; set; }

        public CDs(int id, string title, int releasedate, int prise, string artist) : base(id, title, prise, releasedate)//base class constructor
        {
            this.artist=artist;
        }
        public void displayinfo(string auther)
        {
            Console.WriteLine($"artist : {artist}");
        }
    }

    public partial class DVDs : Media<string>//cant pass multip,le type generic instance have one type
    {
        public string director { get; set; }

        public DVDs(int id, string title, int releasedate, int prise, string director) : base(id, title, prise, releasedate)//base constructor
        {
            this.director = director;
        }
        public void displayinfo(string auther)
        {
            Console.WriteLine($"director : {director}");
        }


    }
    //as we declared partial class so we can add more method in this class separately
    public partial class Books :Media<string>
    {
        public static IEnumerable<Books> getbyyear(List<Books> bok,int year)
        { 
            return bok.Where(book => book.releasedate>year);//filtering from which yeasr i want to get the book
        }
    }
    public  partial class CDs : Media<string>
    {
       public static  IEnumerable<CDs> getbyyear(List<CDs> cds, int year)
        {
            return cds.Where(book => book.releasedate > year);//filtering from which yeasr i want to get the book
        }
    }
    public partial class DVDs : Media<string>
    {
        public static IEnumerable<DVDs> getbyyear(List<DVDs> dvds, int year)
        {
            return dvds.Where(book => book.releasedate > year);//filtering from which yeasr i want to get the book
        }
    }  
    
    public class MediaLibrary
    {
        public List<Media<string>> listmedia;//these are just toi access the medialist in other class i have to make it public

        public MediaLibrary()
        {
            listmedia = new List<Media<string>>();
        }

        public void Initializelist()//this are because when i want to cell i have to iterate them in function class but somehow i can access them so i again initialize them here
        {
            listmedia.Add(new Books(1, "The dark knight rises", 1995, 2000, "Christopher nolan"));// these are previuosly created media
            listmedia.Add(new Books(2, "The End of humanity", 2010, 2340, "minhaj"));
            listmedia.Add(new CDs(3, "the lord of the rings", 2020, 3463, "Jahed"));
            listmedia.Add(new CDs(4, "A brief history of time", 2022, 0, "stephen hawkings"));
            listmedia.Add(new DVDs(5, "Inception", 2010, 148, "Christopher Nolan"));
            listmedia.Add(new DVDs(6, "The Lord of the Rings: The Fellowship of the Ring", 2001, 178, "Peter Jackson"));
            listmedia.Add(new DVDs(7, "The Lord of the Rings: The Two Towers", 2002, 179, "Peter Jackson"));
            listmedia.Add(new DVDs(8, "The Lord of the Rings: The Return of the King", 2003, 201, "Peter Jackson"));
            listmedia.Add(new DVDs(9, "The Dark Knight rises", 2008, 152, "Christopher Nolan"));
            listmedia.Add(new DVDs(10, "The untold history of pallestine", 2023, 152, "Minhaj Ali"));
            listmedia.Add(new DVDs(11, "free palestine", 2023, 152, "Minhaj Ali"));
            listmedia.Add(new CDs(12, "Gladiator", 2000, 155, "Ridley Scott"));
            listmedia.Add(new CDs(13, "The Matrix", 1999, 136, "Lana Wachowski"));
            listmedia.Add(new CDs(14, "The Matrix Reloaded", 2003, 138, "Lana Wachowski"));
            listmedia.Add(new CDs(15, "The Matrix Revolutions", 2003, 129, "Lana Wachowski"));
            listmedia.Add(new CDs(16, "Forrest Gump", 1994, 142, "Robert Zemeckis"));
            listmedia.Add(new Books(17, "Forrest Gump", 1994, 142, "Robert Zemeckis"));
            listmedia.Add(new Books(18, "The Matrix Revolutions", 2003, 129, "Lana Wachowski"));
            listmedia.Add(new Books(19, "The Shawshank Redemption", 1994, 142, "Frank Darabont"));
            listmedia.Add(new Books(20, "Avatar", 2009, 162, "James Cameron"));
        }
    }


}
