﻿using FPS.InventorySystem.ItemSystem;
using UnityEngine;

namespace FPS.InventorySystem
{
    [System.Serializable]
	public class WeaponItem : BaseItem, IItem
    { 
        [SerializeField]
        private WeaponData _data;
        public override IBaseData Data
        {
            get { return _data as BaseData; }
            set { _data = value as WeaponData; }
        }

        [SerializeField]
        private WeaponNSData _weaponNSData;
        public override INSData NSData
        {
            get { return _weaponNSData as NSData; }
            set { _weaponNSData = value as WeaponNSData; }
        }

        private IInventory _inventory;
        public override IInventory Inventory
        {
            get
            {
                if(_inventory == null)
                {
                    _inventory = InventoryManager.Instance.GetInventoryByUUID(Data.InventoryUUID);
                }
                return _inventory;
            }
            set { _inventory = value; }
        }
    }
}