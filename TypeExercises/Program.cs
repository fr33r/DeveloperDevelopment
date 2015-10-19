using CastingExercises;

namespace TypeExercises
{
    /*  The following code was written with the intention to refresh or teach
     *  the developer of the fundamentals of casting/type conversion. Some of 
     *  this code may not be new to you at all, but it easy to forget the whys
     *  and where the boundaries lie for casting. It is important to be aware
     *  of this information so that your intentions while coding can be more
     *  focused and concise.
     *  
     *  These concepts are universal for the most part, but I will be focusing
     *  on capabilities of casting in C#. Be aware that some of these capabilities
     *  and syntax are not possible with other languages.
     *  
     *  Below is a resource I consulted prior to creating this hands-on tutorial.
     *  MSDN is always a great resource, so if you haven't already, I would browse
     *  here for any and all microsoft language (C#, VB.NET, etc.) questions.
     *  https://msdn.microsoft.com/en-us/library/ms173105.aspx
     */
    class Program
    {
        static void Main(string[] args)
        {

            #region Overview

            /*
             * Recognize that C# is a statically-typed language, meaning that the type of all variables 
             * are specified at compile time. This provides us developers with the all the greatness known
             * as type checking, which just means that the compiler is better able to tell you if the actions 
             * you are attempting to perform are type-safe (example - the compiler will stop (and laugh at)
             * you for attempting to add two boolean types.
             */

            /*
             * In C#, the following type of type conversions (converting the type specified of variable to another type)
             * are possible:
             * 
             * Implicit conversions             -->     No additional syntax is required. In other words, the conversion
             *                                          occurs behind the scenes without the developer needing to write
             *                                          any additional code.
             *                                          
             *                                          These conversions are type safe and no data will be lost.
             *                                          
             *                                          Examples:
             *                                              -   smaller             -->         larger integral types.
             *                                              -   derived classes     -->         base classes.
             * 
             * Explicit conversions             -->     Require additional syntax known as the cast operator. This is required
             *                                          when data may be lost during the conversion, or the conversion has a chance
             *                                          that it will no succeed.
             *                                          
             *                                          Examples:
             *                                              -   larger numeric type     -->         smaller numeric type.
             *                                              -   base classes            -->         derived class.
             *                                              
             * User-defined conversions         -->     Essentially, the developer can define custom conversion methods that are
             *                                          invoked when a type conversion is attempted for a custom type defined by the
             *                                          developer. Depending on the nature of the type conversion, the developer can
             *                                          choose to allow implicit or mandate explicit conversion of their custom type.
             *                                          
             *                                          https://msdn.microsoft.com/en-us/library/85w54y0a.aspx
             * 
             * Conversions via helper classes   -->     The .NET framework provides us with some helper classes to aid developers 
             *                                          in their quests to cast non-compatible types.
             *                                              
             *                                          Examples:
             *                                              -   System.BitConverter
             *                                              -   System.Convert
             * 
             */

            #endregion

            #region Implicit Conversions

            int intNum = 100;               /* 4 byte (32 bit) number; range of -2,147,483,648 to 2,147,483,647 */
            long longNum = intNum;          /* 8 byte (64 bit) number; range of –9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 */

            byte byteNum = 255;             /* 1 byte (8 bit) number; range of 0 - 255 */
            intNum = byteNum;               /* 4 byte (32 bit) number; range of -2,147,483,648 to 2,147,483,647 */

            short shortNum = 32767;         /* 2 byte (16 bit) number; range of -32,768 to 32,767 */
            intNum = shortNum;              /* 4 byte (32 bit) number; range of -2,147,483,648 to 2,147,483,647 */

            BaseClass baseClass = new BaseClass();
            baseClass = new DerivedClass();

            BaseClass anotherBaseClass = new DerivedClass();

            #endregion

            #region Explict Conversions

            #endregion

            #region User-defined Conversions

            #endregion

            #region Conversions via Helper Classes

            #endregion

            /*
             * RANDOM
             * 
             * Integral types: https://msdn.microsoft.com/en-us/library/c6bf8dw1(v=vs.71).aspx
             * 
             * Non-Integral types: https://msdn.microsoft.com/en-us/library/a6z3yf91(v=vs.71).aspx
             * 
             * Simple types: https://msdn.microsoft.com/en-us/library/aa691144(v=vs.71).aspx
             */
        }
    }
}
