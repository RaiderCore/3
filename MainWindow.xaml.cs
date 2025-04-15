using System.Windows;
using System;


namespace MathCalculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Обработчик нажатия кнопки "Вычислить"
        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            // Проверяем, что введено число от 1 до 30
            if (int.TryParse(VariantTextBox.Text, out int variant) && variant >= 1 && variant <= 30)
            {
                string result = CalculateVariant(variant); // Вычисляем результат
                ResultTextBlock.Text = result; // Выводим результат
            }
            else
            {
                ResultTextBlock.Text = "Неверный номер варианта. Введите число от 1 до 30.";
            }
        }

        // Метод для вычисления результата в зависимости от варианта
        private string CalculateVariant(int variant)
        {
            try
            {
                switch (variant)
                {
                    case 1:
                        double a1 = 1.0, x1 = 2.0, c1 = 3.0;
                        double L1 = Math.Sqrt(Math.Pow(Math.E, 2) - Math.Pow(Math.Cos(Math.Pow(x1, 2) + Math.Pow(a1, 2)), 3)) + Math.Pow(Math.Atan(a1 - Math.Pow(x1, 2)), 2);
                        double e0 = Math.Sqrt(Math.Abs(a1 + x1 * c1));
                        return $"L = {L1}, e0 = {e0}";

                    case 2:
                        double c2 = 1.0, x2 = 2.0, f2 = 3.0, t2 = 4.0;
                        double L2 = Math.Pow(1 / Math.Tan(c2), 2) + (2 * Math.Pow(x2, 2) + 5) / Math.Sqrt(c2 + f2 * t2);
                        return $"L = {L2}";

                    case 3:
                        double y3 = 1.0, h3 = 2.0;
                        double A3 = (Math.Tan(Math.Pow(y3, 3) - Math.Pow(h3, 4)) + Math.Pow(h3, 2)) / (Math.Pow(Math.Sin(h3), 3) + y3);
                        return $"A = {A3}";

                    case 4:
                        double y4 = 1.0, x4 = 2.0;
                        double F4 = Math.Sqrt(Math.Pow(2 + y4, 2) + Math.Sqrt(Math.Sin(y4 + 5))) / (Math.Log(x4 + 1) - Math.Pow(y4, 3));
                        return $"F = {F4}";

                    case 5:
                        double x5 = 1.0, z5 = 2.0, y5 = 3.0;
                        double G5 = (Math.Tan(Math.Pow(x5, 4) - 6) - Math.Pow(Math.Cos(z5 + y5), 2)) / Math.Pow(Math.Cos(Math.Pow(x5, 2)), 4);
                        return $"G = {G5}";

                    case 6:
                        double x6 = 1.0, b6 = 2.0, a6 = 3.0, y6 = 4.0;
                        double K6 = (Math.Sqrt(x6 + b6 - a6) + Math.Log(y6)) / Math.Atan(b6 + a6);
                        return $"K = {K6}";

                    case 7:
                        double x7 = 1.0, y7 = 2.0, a7 = 3.0;
                        double D7 = (Math.Cos(Math.Pow(x7, 3) + 6) - Math.Sin(y7 - a7)) / (Math.Log(Math.Pow(x7, 2)) - 2 * Math.Pow(Math.Sin(x7), 2));
                        return $"D = {D7}";

                    case 8:
                        double a8 = 1.0, y8 = 2.0, c8 = 3.0, x8 = 4.0;
                        double P8 = (Math.Pow(a8, 3) + Math.Pow(Math.Sin(y8 - c8), 4)) / (Math.Pow(Math.Sin(x8 + y8), 3) + Math.Abs(x8 - y8));
                        return $"P = {P8}";

                    case 9:
                        double y9 = 1.0, d9 = 2.0, x9 = 3.0;
                        double R9 = (Math.Pow(Math.Cos(y9), 3) + Math.Pow(2, d9)) / (Math.Exp(y9) + Math.Log(Math.Pow(Math.Sin(x9), 2) + 7.4));
                        return $"R = {R9}";

                    case 10:
                        double x10 = 1.0, y10 = 2.0;
                        double U10 = (Math.Exp(x10) + Math.Pow(Math.Cos(x10 - 4), 2)) / (Math.Atan(x10) + 5.2 * y10);
                        return $"U = {U10}";
                    case 11:
                        
                        double y11 = 1.0, x11 = 2.0;
                        double I11 = (2.33 * Math.Log(Math.Sqrt(1 + Math.Pow(Math.Cos(y11), 3)))) / (Math.Exp(y11) + Math.Pow(Math.Sin(x11), 2));
                        return $"U = {I11}";


                    case 12:
                        
                        double y12 = 1.0, x12 = 2.0, a12 = 3.0;
                        double G12 = (Math.Pow(Math.Cos(y12), 3) + 4 - (x12 + y12)) / (Math.Pow(Math.Atan(x12 + a12), 2) * Math.Pow(x12, 5));
                        return $"U = {G12}";


                    case 13:
                        
                        double a13 = 1.0, x13 = 2.0, b13 = 3.0;
                        double R13 = a13 / (x13 - a13) + (Math.Pow(b13, x13) + Math.Pow(Math.Cos(x13), 3)) / (Math.Pow(Math.Log10(a13), 4) + 4.5);
                        return $"U = {R13}";


                    case 14:
                        
                        double x14 = 1.0;
                        double R14 = (Math.Pow(Math.Sin(Math.Pow(x14, 2) + 4), 2) + 4.3) / Math.Pow(Math.Sin(Math.Pow(x14, 4)), 3);
                        return $"U = {R14}";


                    case 15:
                        
                        double m15 = 1.0, y15 = 2.0;
                        double N15 = (Math.Pow(m15, 2) + 2.8 * m15 + 0.355) / (Math.Cos(2 * y15) + 3.6);
                        return $"U = {N15}";


                    case 16:
                        
                        double x16 = 1.0, y16 = 2.0, t16 = 3.0;
                        double P16 = (Math.Pow(Math.Sin(x16), 3) + Math.Log(2 * y16 + 3 * x16)) / (Math.Pow(t16, 2) + Math.Sqrt(x16));
                        return $"U = {P16}";


                    case 17:
                        
                        double x17 = 1.0, b17 = 2.0, a17 = 3.0, y17 = 4.0;
                        double T17 = (Math.Sqrt(x17 + b17 - a17) + Math.Log(y17)) / Math.Atan(b17 + a17);
                        return $"U = {T17}";


                    case 18:
                        
                        double y18 = 1.0, t18 = 2.0;
                        double S18 = (4.351 * Math.Pow(y18, 3) + 2 * t18 * Math.Log(t18)) / (Math.Cos(2 * y18) + 4.351);
                        return $"U = {S18}";


                    case 19:
                        
                        double K19 = 1.0, a19 = 2.0, b19 = 3.0, x19 = 4.0, y19 = 5.0;
                        double D19 = (Math.Pow(K19, -a19 / 6) - Math.Cos(3 * a19 * b19)) / Math.Pow(Math.Sin(a19 - Math.Asin(x19) + Math.Log(y19)), 2);
                        return $"U = {D19}";


                    case 20:
                        
                        double y20 = 1.0, x20 = 2.0, b20 = 3.0, c20 = 4.0, a20 = 5.0;
                        double U20 = (Math.Pow(Math.Tan(y20), 3) + Math.Pow(Math.Sin(x20), 3) * Math.Sqrt(b20 - c20)) / Math.Sqrt(a20 - b20 + c20);
                        return $"U = {U20}";


                    case 21:
                        
                        double z21 = 1.0, x21 = 2.0, a21 = 3.0;
                        double N21 = Math.Pow(z21 + Math.Sqrt(x21), 1.0 / 3) / (Math.Exp(2) + Math.Pow(a21, 2) * Math.Atan(x21));
                        return $"U = {N21}";

                    case 22:
                        
                        double x22 = 1.0, y22 = 2.0;
                        double F22 = Math.Cos(Math.Pow(x22, 2) + 2) + (3.5 * Math.Pow(x22, 2) + 1) / Math.Pow(Math.Cos(y22), 3);
                        return $"U = {F22}";

                    case 23:
                        
                        double x23 = 1.0, z23 = 2.0, b23 = 3.0, a23 = 4.0;
                        double F23 = (Math.Sqrt(Math.Abs(x23) + Math.Pow(Math.Cos(x23), 3) + Math.Pow(z23, 4))) / (Math.Log(x23) - Math.Asin(b23 * x23 - a23));
                        return $"U = {F23}";


                    case 24:
                        
                        double b24 = 1.0, x24 = 2.0, a24 = 3.0, z24 = 4.0;
                        double f24 = (Math.Pow(Math.Cos(b24 * Math.Pow(x24, 2)), 3) - (Math.Sin(Math.Pow(a24, 2)) + Math.Cos(Math.Pow(x24, 2) + Math.Pow(z24, 2) - Math.Pow(a24, 2)))) / (Math.Asin(Math.Pow(a24, 2)) + Math.Acos(Math.Pow(x24, 2) - Math.Pow(a24, 2)));
                        return $"U = {f24}";


                    case 25:
                        
                        double a25 = 1.0, y25 = 2.0, x25 = 3.0;
                        double J25 = (Math.Pow(1 / Math.Tan(Math.Pow(a25, 3)), 2) + Math.Pow(Math.Atan(a25), 2)) / Math.Sqrt(Math.Pow(y25, 4) * x25);
                        return $"U = {J25}";


                    case 26:
                        
                        double x26 = 1.0, y26 = 2.0, k26 = 3.0;
                        double U26 = (Math.Log(Math.Pow(x26, 3) + y26) - Math.Pow(y26, 4)) / (Math.Exp(y26) + 5.4 * Math.Pow(k26, 3));
                        return $"U = {U26}";


                    case 27:
                        
                        double a27 = 1.0, x27 = 2.0, y27 = 3.0, c27 = 4.0;
                        double P27 = (Math.Pow(a27, 2) + Math.Acos(a27 + x27) - Math.Pow(Math.Sin(y27 - c27), 4)) / (Math.Pow(Math.Sin(x27 + y27), 3) + Math.Abs(x27 - y27));
                        return $"U = {P27}";

                    case 28:
                        
                        double x28 = 1.0, z28 = 2.0, y28 = 3.0;
                        double G28 = (Math.Tan(Math.Pow(x28, 4) - 6) - Math.Pow(Math.Cos(z28 + Math.Pow(x28, 3) * y28), 3)) / Math.Pow(Math.Cos(Math.Pow(x28, 2)), 4);
                        return $"U = {G28}";


                    case 29:
                        
                        double y29 = 1.0, d29 = 2.0, x29 = 3.0;
                        double R29 = (Math.Pow(Math.Cos(y29), 2) + 2.4 * d29) / (Math.Exp(y29) + Math.Log(Math.Pow(Math.Sin(x29), 2) + 6));
                        return $"U = {R29}";

                    case 30:
                        
                        double x30 = 1.0, b30 = 2.0;
                        double K30 = Math.Sqrt(Math.Pow(3 + x30, 2) - Math.Log(x30)) / (Math.Exp(3) + Math.Asin(b30 * Math.Pow(x30, 2)));
                        return $"U = {K30}";


                    default:
                        return "Вычисление для этого варианта еще не реализовано.";
                }
            }
            catch (Exception ex)
            {
                return $"Ошибка при вычислении: {ex.Message}";
            }
        }
    }
}