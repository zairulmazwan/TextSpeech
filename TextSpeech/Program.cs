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
            synthesizer.Speak("Hi Zairul, good morning. Have a nice day. 1. Take your breakfast!");
        }
    }
}
