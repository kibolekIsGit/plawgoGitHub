﻿using plawgoGitHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plawgoGitHub.Logic.Interfaces
{
    public interface IGigLogic : ILogic
    {
        void Add(Gig gig);
    }
}
