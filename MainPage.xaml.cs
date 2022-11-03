using NAudio.Wave;

namespace MauiSoundTest;

public partial class MainPage : ContentPage
{

    public MainPage()
	{
		InitializeComponent();
	}

	private void NotesSeparatelyClick(object sender, EventArgs e)
	{
      
        AudioPlaybackEngine.Instance.PlaySound(@"C:\Users\kiespetch1\Downloads\MusyngKite_acoustic_grand_piano-mp3_C6.mp3");
        Thread.Sleep(1000);
        AudioPlaybackEngine.Instance.PlaySound(@"C:\Users\kiespetch1\Downloads\MusyngKite_acoustic_grand_piano-mp3_D6.mp3");
        SemanticScreenReader.Announce(NotesSeparatelyButton.Text);
	}
    private void NotesInOneTimeClick(object sender, EventArgs e)
    {
        var input = new AudioFileReader(@"C:\Users\kiespetch1\Downloads\MusyngKite_acoustic_grand_piano-mp3_C6.mp3");
        AudioPlaybackEngine.Instance.PlaySound(@"C:\Users\kiespetch1\Downloads\MusyngKite_acoustic_grand_piano-mp3_C6.mp3");
        AudioPlaybackEngine.Instance.PlaySound(@"C:\Users\kiespetch1\Downloads\MusyngKite_acoustic_grand_piano-mp3_D6.mp3");

        SemanticScreenReader.Announce(NotesInOneTimeButton.Text);
    }
  

 
}

