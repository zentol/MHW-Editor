﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using MHW_Template;

namespace MHW_Editor.Models {
    public abstract class MhwItem : IMhwItem {
        public byte[] Bytes { get; }

        [SortOrder(999999998)]
        public ulong Offset { get; }

        public abstract string Name { get; }
        public bool Changed { get; set; }

        [SortOrder(999999999)]
        [DisplayName("Raw Data")]
        public string Raw_Data => BitConverter.ToString(Bytes).Replace("-", ", ");

        protected MhwItem(byte[] bytes, ulong offset) {
            Bytes = bytes;
            Offset = offset;
        }

        protected T GetData<T>(int offset) where T : struct {
            return Bytes.GetData<T>(offset);
        }

        protected void SetData<T>(int offset, T value) where T : struct {
            var rawData = new byte[Marshal.SizeOf(value)];
            var handle = GCHandle.Alloc(rawData, GCHandleType.Pinned);

            try {
                var rawDataPtr = handle.AddrOfPinnedObject();
                Marshal.StructureToPtr(value, rawDataPtr, false);
            } finally {
                handle.Free();
            }

            // rawData is now a byte arr containing the value we want to save.
            // Copy rawData to the right offset in bytes.
            Array.Copy(rawData, 0, Bytes, offset, rawData.Length);

            Changed = true;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void OnPropertyChanged(params string[] propertyName) {
            foreach (var name in propertyName) {
                OnPropertyChanged(name);
            }
        }
    }
}