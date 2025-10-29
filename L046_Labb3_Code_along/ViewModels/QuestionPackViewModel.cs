using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using L046_Labb3_Code_along.Models;

namespace L046_Labb3_Code_along.ViewModels
{
    internal class QuestionPackViewModel : ViewModelBase
    {
        private readonly QuestionPack _model;

        public QuestionPackViewModel(QuestionPack model)
        {
            _model = model;
        }

        public string Name
        {
            get => _model.Name;
            set
            {
                _model.Name = value;
                RaisePropertyChanged();
            }
        }

        public Difficulty Difficulty
        {
            get => _model.Difficulty;
            set
            {
                _model.Difficulty = value;
                RaisePropertyChanged();
            }
        }

        public int TimeLimitInSeconds
        {
            get => _model.TimeLimitInSeconds;
            set
            {
                _model.TimeLimitInSeconds = value;
                RaisePropertyChanged();
            }
        }
    }
}
