﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2.Provider
{
    public class AllDevicesInShop
    {
        private Device[] _devices;
        public AllDevicesInShop()
        {
            _devices = new Device[10];
        }

        public Device[] GetShopDevices(Currency current)
        {
            _devices[0] = new Device() { Id = 100, Name = "Laptop", Model = "ASUS TUF FX516PE-HN004 Eclipse Gray", Price = 31999, Currency = current };
            _devices[1] = new Device() { Id = 111, Name = "Laptop", Model = "ACER Nitro 5 AN515-44 Black", Price = 32999, Currency = current };
            _devices[2] = new Device() { Id = 122, Name = "Monitor", Model = "Samsung Curved C27T55", Price = 6535, Currency = current };
            _devices[3] = new Device() { Id = 133, Name = "Monitor", Model = "ACER Nitro XZ272P", Price = 10159, Currency = current };
            _devices[4] = new Device() { Id = 144, Name = "Smartphone", Model = "Samsung Galaxy S21 8/128GB Phantom Grey", Price = 23999, Currency = current };
            _devices[5] = new Device() { Id = 155, Name = "Printer", Model = "Canon PIXMA TS3340", Price = 2699, Currency = current };
            _devices[6] = new Device() { Id = 166, Name = "PC", Model = "ZEVS PC A800U", Price = 14549, Currency = current };
            _devices[7] = new Device() { Id = 177, Name = "PC", Model = "ZEVS PC10815U", Price = 24499, Currency = current };
            _devices[8] = new Device() { Id = 188, Name = "Laptop", Model = "ASUS TUF FX516PE-HN004 Eclipse Gray", Price = 31799, Currency = current };
            _devices[9] = new Device() { Id = 199, Name = "Laptop", Model = "ASUS TUF FX516PE-HN004 Eclipse Gray", Price = 31279, Currency = current };

            return _devices;
        }
    }
}
