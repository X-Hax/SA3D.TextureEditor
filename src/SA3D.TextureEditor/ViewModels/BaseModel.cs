﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SA3D.TextureEditor.ViewModels
{
    /// <summary>
    ///
    /// </summary>
    public class BaseModel : INotifyPropertyChanged
    {
        /// <summary>
        ///
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        ///
        /// </summary>
        /// <param name="propertyName"></param>
        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
