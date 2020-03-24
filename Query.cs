using System.Collections.Generic;

#nullable enable

namespace InferenceRepro
{
    public class Query
    {
        public bool Wrong(List<string> values) => true;
        public bool StillWrong(List<string>? values) => true;
    }
}
