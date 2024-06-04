using System.IO;
using System.Net;
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
using Microsoft.Win32;

namespace WpfApp3;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    
    
    public MainWindow()
    {
        InitializeComponent();
    }

    private void BtnGen_OnClick(object sender, RoutedEventArgs e)
    {
        if (!File.Exists("List.txt"))
            return;
        var text = File.ReadAllText("List.txt");
        
        var listStudents = text.Split('\n');
        
        Random rnd = new Random();
        
        int index = rnd.Next(0, listStudents.Length);
        
        string currentFio = listStudents[index];
        
        if (!StudentsList.Items.Contains(currentFio))
            StudentsList.Items.Add(currentFio);
    }

    private void BtnTrash_OnClick(object sender, RoutedEventArgs e)
    {
        
    }
}