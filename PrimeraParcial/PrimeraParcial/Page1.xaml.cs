using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrimeraParcial
{
    public class Assignment
    {
        public String Professor { get; set; }
        public String ProfessorImage { get; set; }
        public String Name { get; set; }
        public String PublishedAt { get; set; }
        public String Description { get; set; }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public List<Assignment> Assignments = new List<Assignment>();
        
        public Page1()
        {
            InitializeComponent();
            Assignments.Add(new Assignment() { Professor = "Severus Snape", ProfessorImage = "severus.jpg", Name = "Physic", PublishedAt = "3 Hours ago", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin iaculis risus magna, eget convallis nulla dignissim sed. Donec ultricies volutpat sapien" });
            Assignments.Add(new Assignment() { Professor = "Severus Snape", ProfessorImage = "severus.jpg", Name = "Physic", PublishedAt = "3 Hours ago", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin iaculis risus magna, eget convallis nulla dignissim sed. Donec ultricies volutpat sapien" });
            MyCarousel.ItemsSource = Assignments;
            BindingContext = this;
        }
    }
}