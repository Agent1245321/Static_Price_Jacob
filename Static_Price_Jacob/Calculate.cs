using System;
using System.Collections.Generic;
using System.Text;

namespace Static_Price_Jacob
{
    static class Calculate
    {
        //idk, quite useless
        static float result;

        static Calculate()
        {
            //still dont know why we do this
            result = 0.0f;
        }


        //The Methods
        public static float Add(int int1, int int2)
        {
            return (int1 + int2);
        }

        public static float Subtract(int int1, int int2)
        {
            return (int1 - int2);
        }

        public static float Multiply(int int1, int int2)
        {
            return (int1 * int2);
        }

        public static float Divide(int int1, int int2)
        {
            return (int1 / int2);
        }

        public static float Add(float float1, float float2)
        {
            return (float1 + float2);
        }

        public static float Subtract(float float1, float float2)
        {
            return (float1 - float2);
        }

        public static float Multiply(float float1, float float2)
        {
            return (float1 * float2);
        }

        public static float Divide(float float1, float float2)
        {
            return (float1 / float2);
        }
    }
}
