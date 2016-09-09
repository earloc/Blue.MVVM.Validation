using System;
using System.Collections.Generic;
using System.Text;

namespace Blue.MVVM.Validation {
    public partial interface IValidatable {
        event EventHandler IsValidChanged;
        bool IsValid { get; }

        void SetError(string propertyName, string errorText = null);
        void RemoveError(string propertyName);
    }
}
