using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace firstApp
{
    class Hasher
    {
        public List<ulong> Store_input(string input)
        {
            List<ulong> block = new List<ulong>();
            int stringlength = input.Length;
            for (int i = 0; i < stringlength; i++)
            {
                block.Add(input[i]);
            }
            return block;
        }



        public int[] Bitset(int num, int size)
        {
            BitArray bitarr = new BitArray(new int[] { num });
            int[] arr = new int[size];
            for (int i = 0; i < bitarr.Length; i++)
            {
                if (bitarr[i])
                    arr[i] = 1;
                else
                    arr[i] = 0;
            }
            Array.Reverse(arr);
            return arr;
        }



        public ulong[] UBitset(ulong ele, int size)
        {
            ulong[] num = new ulong[size];
            for (int i = 0; i < size; i++)
            {
                num[i] = ele % 2;
                ele /= 2;
            }
            Array.Reverse(num);
            return num;
        }



        public string BitsetPad(ulong ele, int size)
        {
            string num = "";
            for (int i = 0; i < size; i++)
            {

                num = ele % 2 + num;
                ele /= 2;
            }
            return num;
        }



        public int[] BitsetString(string str)
        {
            int[] arr = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '1')
                    arr[i] = 1;
                else
                    arr[i] = 0;
            }
            return arr;
        }



        public string ConvertToString(int[] arr)
        {
            string converted = string.Join(null, arr.Select(x => x.ToString()).ToArray());
            return converted;
        }



        public List<ulong> Pad_to_512bits(List<ulong> block)
        {
            int l = block.Count * 8;
            block.Add(128);

            int k = 440 - l;

            for (int i = 0; i < k / 8; i++)
            {
                block.Add(0);

            }



            int[] sixty_four_size = Bitset(l, 64);

            string sixty_four_string = ConvertToString(sixty_four_size);
            for (int i = 0; i < 63; i = i + 8)
            {
                int tempsum = 0;
                int y = 1;
                int[] temp = BitsetString(sixty_four_string.Substring(i, 8));
                for (int x = 7; x >= 0; x--)
                {
                    tempsum += temp[x] * y;
                    y *= 2;

                }


                block.Add((ulong)tempsum);

            }
            return block;
        }



        public string Padding(List<ulong> block)
        {
            string temp;
            string padded = "";
            for (int i = 0; i < block.Count; i++)
            {
                temp = BitsetPad(block[i], 8);
                padded += temp;
            }
            return padded;
        }



        public ulong[] OrArrays(ulong[] a, ulong[] b)
        {
            ulong[] output = new ulong[a.Length];
            for (int u = 0; u < a.Length; u++)
            {
                output[u] = a[u] | b[u];
            }
            return output;
        }



        public ulong ConvertToulong(ulong[] input)
        {
            Array.Reverse(input);
            ulong conv = 0;
            ulong num = 1;
            for (int i = 0; i < input.Length; i++)
            {
                conv += num * input[i];
                num *= 2;
            }
            return conv;
        }



        public List<ulong> Resize_block(List<ulong> input)
        {
            ulong[] inputArr = input.ToArray();

            ulong[] output = new ulong[16];
            for (int i = 0; i < 64; i += 4)
            {
                ulong temp = inputArr[i] << 24;
                ulong[] tempArr = UBitset(temp, 32);
                temp = inputArr[i + 1] << 16;
                tempArr = OrArrays(tempArr, UBitset(temp, 32));
                temp = inputArr[i + 2] << 8;
                tempArr = OrArrays(tempArr, UBitset(temp, 32));
                temp = inputArr[i + 3];
                tempArr = OrArrays(tempArr, UBitset(temp, 32));
                output[i / 4] = ConvertToulong(tempArr);


            }
            //foreach (ulong num in output)
            //{
            //    Console.WriteLine(num);
            //}
            return output.ToList();
        }


        //MACROS
        public ulong CH(ulong x, ulong y, ulong z)
        {
            return ((x) & (y)) ^ (~x & (z));
        }
        public ulong MAJ(ulong x, ulong y, ulong z)
        {
            return ((x) & (y)) ^ ((x) & (z)) ^ ((y) & (z));
        }
        public ulong ROTR(ulong x, int n)
        {
            return (x >> n) | (x << (32 - n));
        }
        public ulong SHR(ulong x, int n)
        {
            return x >> n;
        }
        public ulong S0(ulong x)
        {
            return ROTR(x, 7) ^ ROTR(x, 18) ^ SHR(x, 3);
        }
        public ulong S1(ulong x)
        {
            return ROTR(x, 17) ^ ROTR(x, 19) ^ SHR(x, 10);
        }
        public ulong E0(ulong x)
        {
            return ROTR(x, 2) ^ ROTR(x, 13) ^ ROTR(x, 22);
        }
        public ulong E1(ulong x)
        {
            return ROTR(x, 6) ^ ROTR(x, 11) ^ ROTR(x, 25);
        }

        public string Word(List<ulong> block, int n)
        {

            ulong[] W = new ulong[64];
            for (int i = 0; i <= 15; i++)
            {
                W[i] = block[i];
            }

            for (int i = 16; i <= 63; i++)
            {
                W[i] = S1(W[i - 2]) + W[i - 7] + S0(W[i - 15]) + W[i - 16];

                W[i] = W[i];
            }

            string temp = BitsetPad(W[n - 1], 32);
            return temp;
        }
        public string Show_as_hex(ulong input)
        {
            string hexOutput = String.Format("{0:X}", input);
            char[] Output = new char[8];
            for (int i = 0; i < 8; i++)
            {
                Output[i] = hexOutput[i];
            }
            string newString = new string(Output);
            return newString;
        }
        public string Compute_hash(List<ulong> block)
        {
            ulong[] k = new ulong[64]{
                    0x428a2f98,0x71374491,0xb5c0fbcf,0xe9b5dba5,0x3956c25b,0x59f111f1,
                    0x923f82a4,0xab1c5ed5,0xd807aa98,0x12835b01,0x243185be,0x550c7dc3,
                    0x72be5d74,0x80deb1fe,0x9bdc06a7,0xc19bf174,0xe49b69c1,0xefbe4786,
                    0x0fc19dc6,0x240ca1cc,0x2de92c6f,0x4a7484aa,0x5cb0a9dc,0x76f988da,
                    0x983e5152,0xa831c66d,0xb00327c8,0xbf597fc7,0xc6e00bf3,0xd5a79147,
                    0x06ca6351,0x14292967,0x27b70a85,0x2e1b2138,0x4d2c6dfc,0x53380d13,
                    0x650a7354,0x766a0abb,0x81c2c92e,0x92722c85,0xa2bfe8a1,0xa81a664b,
                    0xc24b8b70,0xc76c51a3,0xd192e819,0xd6990624,0xf40e3585,0x106aa070,
                    0x19a4c116,0x1e376c08,0x2748774c,0x34b0bcb5,0x391c0cb3,0x4ed8aa4a,
                    0x5b9cca4f,0x682e6ff3,0x748f82ee,0x78a5636f,0x84c87814,0x8cc70208,
                    0x90befffa,0xa4506ceb,0xbef9a3f7,0xc67178f2
            };

           ulong H0 = 0x6a09e667;
           ulong H1 = 0xbb67ae85;
           ulong H2 = 0x3c6ef372;
           ulong H3 = 0xa54ff53a;
           ulong H4 = 0x510e527f;
           ulong H5 = 0x9b05688c;
           ulong H6 = 0x1f83d9ab;
           ulong H7 = 0x5be0cd19;

            //Console.WriteLine("Before Computation");
            //Console.Write("H0 = " + Show_as_hex(H0) + " H1 = " + Show_as_hex(H1) + " H2 = " + Show_as_hex(H2) + " H3 = " + Show_as_hex(H3) + " H4 = " + Show_as_hex(H4) + " H5 = " + Show_as_hex(H5) + " H6 = " + Show_as_hex(H6) + " H7 = " + Show_as_hex(H7));

            ulong[] W = new ulong[64];
            for (int i = 0; i <= 15; i++)
            {
                W[i] = block[i];

            }

            for (int i = 16; i <= 63; i++) //Generate words 17 - 64 in the message schedule as per the specification
            {
                W[i] = S1(W[i - 2]) + W[i - 7] + S0(W[i - 15]) + W[i - 16]; //Function defined from the specification

            }

            // Working Variables as per the specification
           ulong temp1;
           ulong temp2;
           ulong a = H0;
           ulong b = H1;
           ulong c = H2;
           ulong d = H3;
           ulong e = H4;
           ulong f = H5;
           ulong g = H6;
           ulong h = H7;

            for (int i = 0; i < 64; i++)
            {
                temp1 = (h + E1(e) + CH(e, f, g) + k[i] + W[i]);
                temp2 = (E0(a) + MAJ(a, b, c));
                h = g;
                g = f;
                f = e;
                e = (d + temp1);
                d = c;
                c = b;
                b = a;
                a = (temp1 + temp2);
            }

            H0 = (H0 + a);
            H1 = (H1 + b);
            H2 = (H2 + c);
            H3 = (H3 + d);
            H4 = (H4 + e);
            H5 = (H5 + f);
            H6 = (H6 + g);
            H7 = (H7 + h);


            return Show_as_hex(H0) + Show_as_hex(H1) + Show_as_hex(H2) + Show_as_hex(H3) + Show_as_hex(H4) + Show_as_hex(H5) + Show_as_hex(H6) + Show_as_hex(H7);
        }
    }
}
