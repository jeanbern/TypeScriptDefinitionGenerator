using System.Diagnostics.CodeAnalysis;

namespace TypeScriptDefinitionGenerator
{
    public class IntellisenseProperty
    {
        public IntellisenseProperty()
        {

        }
        public IntellisenseProperty(IntellisenseType type, string propertyName)
        {
            Type = type;
            Name = propertyName;
        }

        public bool ReadOnly { get; set; }

        public string Name { get; set; }

        public string NameWithOption { get { return (this.Type != null && this.Type.IsOptional) ? this.Name + "?" : this.Name; } }

        public string Modifiers => ReadOnly ? "readonly " : string.Empty;

        [SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods",
            Justification = "Unambiguous in this context.")]
        public IntellisenseType Type { get; set; }

        public string Summary { get; set; }
        public string InitExpression { get; set; }
    }
}