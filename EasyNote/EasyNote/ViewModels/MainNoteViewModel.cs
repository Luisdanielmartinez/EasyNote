using EasyNote.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace EasyNote.ViewModels
{
   public class MainNoteViewModel
    {
        public ICommand DragStartingCommand => new Command<Note>((param) =>
        {
            _dragEvent = param;
        });

        public ICommand DropOverCommand => new Command(() =>
        {
            if (Events.Contains(_dragEvent))
                Events.Remove(_dragEvent);
        });

        public ObservableCollection<Note> Events { get; }

        private Note _dragEvent;

        public MainNoteViewModel()
        {
            Events = new ObservableCollection<Note>()
            {
                {new Note("Go for a walk", "Home", DateTime.Now.AddHours(3), Color.OrangeRed) },
                {new Note("Finish PR", "Work", DateTime.Now.AddHours(5), Color.ForestGreen) },
                {new Note("Watch a movie", "Home", DateTime.Now.AddMinutes(40), Color.LightSkyBlue) },
            };
        }
    }
}
