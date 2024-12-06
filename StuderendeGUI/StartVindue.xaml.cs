using BLL.Studerende;
using DTO.Model;
using System;
using System.Windows;

namespace StuderendeGUIWPF
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        StuderendeBLL bll = new StuderendeBLL();
        Studerende studerende;

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            studerende = bll.GetStuderende(Int32.Parse(SearchId.Text));
            Navn.Content = studerende.Navn;
            Years.Content = studerende.Alder.ToString();
            //NameToChangeOrAdd.Text = studerende.Navn;
            //Years.Text = studerende.Alder.ToString();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Studerende newStuderende = new Studerende(NameToChangeOrAdd.Text, DateTime.Parse(Studiestart.Text), int.Parse(Alder.Text), Studietype.Text);
            bll.AddStuderende(newStuderende);
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            studerende.Alder = int.Parse(Alder.Text);
            studerende.Navn = NameToChangeOrAdd.Text;
            studerende.Studiestart = DateTime.Parse(Studiestart.Text);
            studerende.Studietype = Studietype.Text;
            bll.EditStuderende(studerende);
        }
    }
}

