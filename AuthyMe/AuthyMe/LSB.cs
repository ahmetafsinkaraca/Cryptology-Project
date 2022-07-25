using System;
using System.Drawing;

namespace AuthyMe
{
    class LSB 
    {
        public enum State
        {
            Hide, zeroLength
        };

        public static Bitmap textEmbed(string text, Bitmap bmp)
        {
            State state = State.Hide;

            int charIndex = 0;
            int charValue = 0;
            long pixelElementIndex = 0;
            int zeroCount = 0;
            int R = 0, G = 0, B = 0;

            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    Color pixel = bmp.GetPixel(j, i);
                    R = pixel.R - pixel.R % 2;
                    G = pixel.G - pixel.G % 2;
                    B = pixel.B - pixel.B % 2;

                    for (int n = 0; n < 3; n++)
                    {
                        if (pixelElementIndex % 8 == 0)
                        {
                            if (state == State.zeroLength && zeroCount == 8)
                            {
                                if ((pixelElementIndex - 1) % 3 < 2)
                                {
                                    bmp.SetPixel(j, i, Color.FromArgb(R, G, B));
                                }
                                return bmp;
                            }
                            if (charIndex >= text.Length)
                            {
                                state = State.zeroLength;
                            }
                            else
                            {
                                charValue = text[charIndex++];

                                Console.WriteLine(charValue);
                            }
                        }

                        switch (pixelElementIndex % 3)
                        {
                            case 0:
                                {
                                    if (state == State.Hide)
                                    {
                                        R += charValue % 2;
                                        charValue /= 2;

                                        Console.WriteLine(R.ToString());
                                    }
                                    break;
                                }

                            case 1:
                                {
                                    if (state == State.Hide)
                                    {
                                        G += charValue % 2;
                                        charValue /= 2;

                                        Console.WriteLine(G.ToString());
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    if (state == State.Hide)
                                    {
                                        B += charValue % 2;
                                        charValue /= 2;

                                        Console.WriteLine(B.ToString());
                                    }
                                    bmp.SetPixel(j, i, Color.FromArgb(R, G, B));
                                }
                                break;
                        }

                        pixelElementIndex++;
                        if (state == State.zeroLength)
                        {
                            zeroCount++;
                        }
                    }
                }
            }
            return bmp;
        }

        public static string Extract(Bitmap bmp)
        {
            int colorUnitIndex = 0;
            int charVal = 0;
            string extractedText = "";
            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    Color pixel = bmp.GetPixel(j, i);

                    for (int n = 0; n < 3; n++)
                    {
                        switch (colorUnitIndex % 3)
                        {
                            case 0:
                                {
                                    charVal = charVal * 2 + pixel.R % 2;
                                }
                                break;
                            case 1:
                                {
                                    charVal = charVal * 2 + pixel.G % 2;
                                }
                                break;
                            case 2:
                                {
                                    charVal = charVal * 2 + pixel.B % 2;
                                }
                                break;
                        }
                        colorUnitIndex++;

                        if (colorUnitIndex % 8 == 0)
                        {
                            charVal = reverseBits(charVal);
                            Console.WriteLine(charVal);

                            if (charVal == 0)
                            {
                                return extractedText;
                            }
                            if (charVal == 94)
                            {
                                charVal = 350;
                            }
                            else if (charVal == 95)
                            {
                                charVal = 351;
                            }
                            else if (charVal == 48)
                            {
                                charVal = 304;
                            }
                            char c = (char)charVal;
                            extractedText += c.ToString();
                        }
                    }
                }
            }
            return extractedText;
        }

        public static int reverseBits(int n)
        {
            int result = 0;
            for (int i = 0; i < 8; i++)
            {
                result = result * 2 + n % 2;
                n /= 2;
            }
            return result;
        }
    }
}

