
using System;
using System.Collections.Generic;

using OOP_HomeWork_3;

namespace OOP_HomeWork_3
{
    class Program_Song
    {
        static void Main(string[] args)
        {

            Console.Write("Nhap so luong bai hat: ");
            int n = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap thong tin bai hat {i + 1} theo dinh dang 'LoaiBaihat_TenBaiHat_ThoiGian': ");
                string[] input = Console.ReadLine().Split('_');
                songs.Add(new Song(input[0], input[1], input[2]));
            }


            Console.Write("Nhap loai danh sach hoặc 'all': ");
            string typeList = Console.ReadLine();


            if (typeList == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
}
