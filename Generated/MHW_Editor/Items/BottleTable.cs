
using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Items {
    public partial class BottleTable {
        public const uint StructSize = 6;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        protected const string Close_Range_displayName = "Close Range";
        protected const int Close_Range_sortIndex = 50;
        [SortOrder(Close_Range_sortIndex)]
        [DisplayName(Close_Range_displayName)]
        public MHW_Template.Weapons.CoatingType Close_Range {
            get => (MHW_Template.Weapons.CoatingType) GetData<byte>(0);
            set {
                SetData(0, (byte) value);
                OnPropertyChanged(nameof(Close_Range));
            }
        }
        protected const string Power_displayName = "Power";
        protected const int Power_sortIndex = 100;
        [SortOrder(Power_sortIndex)]
        [DisplayName(Power_displayName)]
        public MHW_Template.Weapons.CoatingType Power {
            get => (MHW_Template.Weapons.CoatingType) GetData<byte>(1);
            set {
                SetData(1, (byte) value);
                OnPropertyChanged(nameof(Power));
            }
        }
        protected const string Paralysis_displayName = "Paralysis";
        protected const int Paralysis_sortIndex = 150;
        [SortOrder(Paralysis_sortIndex)]
        [DisplayName(Paralysis_displayName)]
        public MHW_Template.Weapons.CoatingType Paralysis {
            get => (MHW_Template.Weapons.CoatingType) GetData<byte>(2);
            set {
                SetData(2, (byte) value);
                OnPropertyChanged(nameof(Paralysis));
            }
        }
        protected const string Poison_displayName = "Poison";
        protected const int Poison_sortIndex = 200;
        [SortOrder(Poison_sortIndex)]
        [DisplayName(Poison_displayName)]
        public MHW_Template.Weapons.CoatingType Poison {
            get => (MHW_Template.Weapons.CoatingType) GetData<byte>(3);
            set {
                SetData(3, (byte) value);
                OnPropertyChanged(nameof(Poison));
            }
        }
        protected const string Sleep_displayName = "Sleep";
        protected const int Sleep_sortIndex = 250;
        [SortOrder(Sleep_sortIndex)]
        [DisplayName(Sleep_displayName)]
        public MHW_Template.Weapons.CoatingType Sleep {
            get => (MHW_Template.Weapons.CoatingType) GetData<byte>(4);
            set {
                SetData(4, (byte) value);
                OnPropertyChanged(nameof(Sleep));
            }
        }
        protected const string Blast_displayName = "Blast";
        protected const int Blast_sortIndex = 300;
        [SortOrder(Blast_sortIndex)]
        [DisplayName(Blast_displayName)]
        public MHW_Template.Weapons.CoatingType Blast {
            get => (MHW_Template.Weapons.CoatingType) GetData<byte>(5);
            set {
                SetData(5, (byte) value);
                OnPropertyChanged(nameof(Blast));
            }
        }
    }
}