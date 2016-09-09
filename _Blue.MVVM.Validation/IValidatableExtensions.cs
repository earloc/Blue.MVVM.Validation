using System;
using System.Collections.Generic;
#if !PRE_45
using System.Runtime.CompilerServices;
#endif
using System.Text;

namespace Blue.MVVM.Validation {
    public static class IValidatableExtensions {

        public static void ValidatesWhen(this IValidatable source, 
            bool condition,
#if !PRE45
            [CallerMemberName]
#endif
            string propertyName = "", 
            string errorText = "") {
            if (condition) {
                source.RemoveError(propertyName);
                return;
            }
            source.SetError(propertyName, errorText);
        }
    }
}
