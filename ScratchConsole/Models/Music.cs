using ScratchConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScratchConsole.Models
{
    public class Music : Movie, IPlayable
    {
        public void Play()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
