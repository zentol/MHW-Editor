
using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Weapons {
    public partial class WeaponWSword {
        public const uint StructSize = 10;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        protected const string Id_displayName = "Id";
        protected const int Id_sortIndex = 50;
        [SortOrder(Id_sortIndex)]
        [DisplayName(Id_displayName)]
        public uint Id {
            get => GetData<uint>(0);
        }
        protected const string Element_1_Type_displayName = "Element 1 Type";
        protected const int Element_1_Type_sortIndex = 100;
        [SortOrder(Element_1_Type_sortIndex)]
        [DisplayName(Element_1_Type_displayName)]
        public MHW_Template.Weapons.Element Element_1_Type {
            get => (MHW_Template.Weapons.Element) GetData<byte>(4);
            set {
                SetData(4, (byte) value);
                OnPropertyChanged(nameof(Element_1_Type));
            }
        }
        protected const string Element_1_Dmg_displayName = "Element 1 Dmg";
        protected const int Element_1_Dmg_sortIndex = 150;
        [SortOrder(Element_1_Dmg_sortIndex)]
        [DisplayName(Element_1_Dmg_displayName)]
        public short Element_1_Dmg {
            get => GetData<short>(5);
            set {
                SetData(5, value);
                OnPropertyChanged(nameof(Element_1_Dmg));
            }
        }
        protected const string Element_2_Type_displayName = "Element 2 Type";
        protected const int Element_2_Type_sortIndex = 200;
        [SortOrder(Element_2_Type_sortIndex)]
        [DisplayName(Element_2_Type_displayName)]
        public MHW_Template.Weapons.Element Element_2_Type {
            get => (MHW_Template.Weapons.Element) GetData<byte>(7);
            set {
                SetData(7, (byte) value);
                OnPropertyChanged(nameof(Element_2_Type));
            }
        }
        protected const string Element_2_Dmg_displayName = "Element 2 Dmg";
        protected const int Element_2_Dmg_sortIndex = 250;
        [SortOrder(Element_2_Dmg_sortIndex)]
        [DisplayName(Element_2_Dmg_displayName)]
        public short Element_2_Dmg {
            get => GetData<short>(8);
            set {
                SetData(8, value);
                OnPropertyChanged(nameof(Element_2_Dmg));
            }
        }
    }
}