using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using WpfApp2.Models;

namespace WpfApp2;


public partial class MainWindow : Window, INotifyPropertyChanged
{
    private List<Message>? messages;

    public event PropertyChangedEventHandler? PropertyChanged;

    public List<Message>? Messages { 
        get => messages; 
        set
        {
            messages = value;
            OnProperty();

        }
             }
    public MainWindow()
    {
        InitializeComponent();
        Messages = new List<Message>()
        {
            new Message("Salam"),
            new Message("Brat"),
            new Message("VCDJSDv")
        }
        ; 
        list.ItemsSource = Messages;
        DataContext = this;
    }
    public void OnProperty([CallerMemberName] string? name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(name)));
    }
}