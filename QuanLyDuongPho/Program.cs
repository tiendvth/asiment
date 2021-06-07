using System;
using System.Text;
using QuanLyDuongPho.controller;
using QuanLyDuongPho.entity;
using QuanLyDuongPho.Model;
using QuanLyDuongPho.view;

namespace QuanLyDuongPho
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //var duongPho = new DuongPho();
            //var duongPhoModel = new DuongPhoModel();
            //duongPhoModel.Save(duongPho);
            // DuongPhoController duongPhoController = new DuongPhoController();
            // duongPhoController.TaoDuongPho();
            DuongphoView duongPhoView = new DuongphoView();
            duongPhoView.ShowMenu();
        }
    }
}