using System;
using System.Speech.Synthesis;

namespace TextSpeech
{
    class Program
    {
        static void Main(string[] args)
        {
            var synthesizer = new SpeechSynthesizer();
            synthesizer.SetOutputToDefaultAudioDevice();
            synthesizer.Speak("Hi Zairul, all we need to do is to make sure we keep talking");
        }
    }
}
