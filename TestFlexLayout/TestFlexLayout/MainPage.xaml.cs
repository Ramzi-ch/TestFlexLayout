using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestFlexLayout
{
	public partial class MainPage : ContentPage
	{
        List<Category> ListCategory;
        public MainPage()
		{            
            InitializeComponent(); 
            ListCategory = new List<Category>
            {
                new Category{Code="0000",Image="gallery.png", NameAr="Name Arabic",NameEn="Name En",ShortNameAr="ShortAr",ShortNameEn="ShortEn"},
                new Category{Code="0000",Image="gallery.png", NameAr="Name Arabic",NameEn="Name En",ShortNameAr="ShortAr",ShortNameEn="ShortEn"},
                new Category{Code="0000",Image="gallery.png", NameAr="Name Arabic",NameEn="Name En",ShortNameAr="ShortAr",ShortNameEn="ShortEn"}
            };
            ListCategorie.ItemsSource = ListCategory;
            this.SizeChanged += OnSizeChanged;
        }       

        void OnSizeChanged(object sender, EventArgs e)
        {

            Debug.WriteLine(this.Width +" "+ this.Height);
            //Debug.WriteLine("width " + L5.Width);
            //if (L5.Width > 0)
            //{
            //    st1.HeightRequest = L5.Width - 40;
            //}

        }
    }
}
