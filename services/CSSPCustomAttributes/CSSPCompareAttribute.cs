namespace CSSPCustomAttributes
{
    /// <summary>
    /// > [!NOTE]
    /// > Custom validation attribute used to replace CompareAttribute.
    /// > <para>Used when generating certain codes.</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    /// <example>
    ///     <code>
    ///         [CSSPMinLength(6)]
    ///         public string FirstName { get; set; }
    ///     </code>
    /// </example>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class CSSPCompareAttribute : CompareAttribute
    {
        /// <summary>
        /// > [!NOTE]
        /// > Constructor.
        /// </summary>
        public CSSPCompareAttribute(string otherProperty) : base(otherProperty)
        {

        }

        /// <summary>
        /// > [!NOTE]
        /// > This method is not used. Own validation system is being used.
        /// </summary>
        /// <param name="value">The value to validate.</param>
        /// <returns>Always returns true.</returns>
        public override bool IsValid(object? value)
        {
            return true;
        }
    }
}
