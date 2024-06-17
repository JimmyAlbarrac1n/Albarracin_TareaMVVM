namespace JimmyAlbarracinApuntesMauiApp.JA_Views;

public partial class JA_AllNotesPage : ContentPage
{
    public JA_AllNotesPage()
    {
        InitializeComponent();
    }
    private void ContentPage_NavigatedTo(object sender, NavigatedToEventArgs e)
    {
        notesCollection.SelectedItem = null;
    }
}