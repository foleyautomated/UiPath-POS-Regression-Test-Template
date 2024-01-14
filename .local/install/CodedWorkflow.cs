using System;
using System.Collections.Generic;
using System.Data;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;
using UiPath.CodedWorkflows.DescriptorIntegration;

namespace Template.POS
{
    public partial class CodedWorkflow : CodedWorkflowBase
    {
        public CodedWorkflow()
        {
            _ = new System.Type[]{typeof(UiPath.Core.Activities.API.ISystemService), typeof(UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService), typeof(UiPath.Testing.API.ITestingService)};
        }

        protected UiPath.Core.Activities.API.ISystemService system { get => serviceContainer.Resolve<UiPath.Core.Activities.API.ISystemService>(); }

        protected UiPath.Testing.API.ITestingService testing { get => serviceContainer.Resolve<UiPath.Testing.API.ITestingService>(); }

        protected UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService uiAutomation { get => serviceContainer.Resolve<UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService>(); }
    }
}

namespace Template.POS.ObjectRepository
{
    public static class Descriptors
    {
        public static class MsPaint
        {
            public static _Implementation._MsPaint.__ByFileName ByFileName { get; private set; } = new _Implementation._MsPaint.__ByFileName();
            public static _Implementation._MsPaint.__FloatingLogo FloatingLogo { get; private set; } = new _Implementation._MsPaint.__FloatingLogo();
            public static _Implementation._MsPaint.__Home Home { get; private set; } = new _Implementation._MsPaint.__Home();
            public static _Implementation._MsPaint.__PinPad PinPad { get; private set; } = new _Implementation._MsPaint.__PinPad();
            public static _Implementation._MsPaint.__Universal Universal { get; private set; } = new _Implementation._MsPaint.__Universal();
        }
    }
}

namespace Template.POS._Implementation
{
    internal class ScreenDescriptorDefinition : IScreenDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }
    }

    internal class ElementDescriptorDefinition : IElementDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }

        public IElementDescriptor ParentElement { get; set; }

        public IElementDescriptor Element { get; set; }
    }

    namespace _MsPaint
    {
        public class __ByFileName : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __ByFileName()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "PkgkKyCF8UuI2e3EnwRcMg/obJn8YZJRkufwexwYs259g", DisplayName = "ByFileName", Screen = this};
            }
        }
    }

    namespace _MsPaint._FloatingLogo
    {
        public class __Logo : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Logo(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "PkgkKyCF8UuI2e3EnwRcMg/_HmoIroHuEGTd7fUF9DXUw", DisplayName = "Logo", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _MsPaint
    {
        public class __FloatingLogo : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __FloatingLogo()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "PkgkKyCF8UuI2e3EnwRcMg/BY6O1g_9N0W1qDCIEZPp9w", DisplayName = "FloatingLogo", Screen = this};
                Logo = new _Implementation._MsPaint._FloatingLogo.__Logo(this, null);
            }

            public _Implementation._MsPaint._FloatingLogo.__Logo Logo { get; private set; }
        }
    }

    namespace _MsPaint._Home._BunRegion
    {
        public class ___1_DavidsOriginalBun : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___1_DavidsOriginalBun(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "PkgkKyCF8UuI2e3EnwRcMg/y68F3wqolU-ToKqkUD05Wg", DisplayName = "1_DavidsOriginalBun", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _MsPaint._Home._BunRegion
    {
        public class ___2_DavidsEverythingBun : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___2_DavidsEverythingBun(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "PkgkKyCF8UuI2e3EnwRcMg/BcUAGrjCCEe1oWODMrDpmw", DisplayName = "2_DavidsEverythingBun", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _MsPaint._Home._BunRegion
    {
        public class ___3_DavidsGfBun : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___3_DavidsGfBun(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "PkgkKyCF8UuI2e3EnwRcMg/nmw_j1EYdUaFT7Ydc-CrzA", DisplayName = "3_DavidsGfBun", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _MsPaint._Home
    {
        public class __BunRegion : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __BunRegion(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "PkgkKyCF8UuI2e3EnwRcMg/VPx0b1xLqkimsJH_ZIH2bg", DisplayName = "BunRegion", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
                _1_DavidsOriginalBun = new _Implementation._MsPaint._Home._BunRegion.___1_DavidsOriginalBun(screenDescriptor, this);
                _2_DavidsEverythingBun = new _Implementation._MsPaint._Home._BunRegion.___2_DavidsEverythingBun(screenDescriptor, this);
                _3_DavidsGfBun = new _Implementation._MsPaint._Home._BunRegion.___3_DavidsGfBun(screenDescriptor, this);
            }

            public _Implementation._MsPaint._Home._BunRegion.___1_DavidsOriginalBun _1_DavidsOriginalBun { get; private set; }

            public _Implementation._MsPaint._Home._BunRegion.___2_DavidsEverythingBun _2_DavidsEverythingBun { get; private set; }

            public _Implementation._MsPaint._Home._BunRegion.___3_DavidsGfBun _3_DavidsGfBun { get; private set; }
        }
    }

    namespace _MsPaint._Home._CondimentRegion
    {
        public class ___01_DavidsCheese : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___01_DavidsCheese(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "PkgkKyCF8UuI2e3EnwRcMg/hoaZLyMngkOUxuUddRDaWw", DisplayName = "01_DavidsCheese", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _MsPaint._Home._CondimentRegion
    {
        public class ___02_DavidsKetchup : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___02_DavidsKetchup(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "PkgkKyCF8UuI2e3EnwRcMg/C8K8aByKZ0unn3fJEA3Jfg", DisplayName = "02_DavidsKetchup", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _MsPaint._Home._CondimentRegion
    {
        public class ___03_DavidsRelish : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___03_DavidsRelish(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "PkgkKyCF8UuI2e3EnwRcMg/_CRVZ7pClkOp29xE5zK3tA", DisplayName = "03_DavidsRelish", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _MsPaint._Home._CondimentRegion
    {
        public class ___04_DavidsMustard : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___04_DavidsMustard(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "PkgkKyCF8UuI2e3EnwRcMg/4Pk2SeR8BkCOKcDFhSXD-Q", DisplayName = "04_DavidsMustard", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _MsPaint._Home._CondimentRegion
    {
        public class ___05_DavidsBbq : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___05_DavidsBbq(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "PkgkKyCF8UuI2e3EnwRcMg/XhAVXuBNbk-jlwOJ0EDF8Q", DisplayName = "05_DavidsBbq", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _MsPaint._Home._CondimentRegion
    {
        public class ___06_DavidsBananaPeppers : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___06_DavidsBananaPeppers(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "PkgkKyCF8UuI2e3EnwRcMg/vn1_UmEzTEK5FKNh4lCzTw", DisplayName = "06_DavidsBananaPeppers", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _MsPaint._Home._CondimentRegion
    {
        public class ___07_DavidsPickedRedOnion : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___07_DavidsPickedRedOnion(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "PkgkKyCF8UuI2e3EnwRcMg/c-wb8RGIrUOMofNu_ZUG5w", DisplayName = "07_DavidsPickedRedOnion", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _MsPaint._Home._CondimentRegion
    {
        public class ___08_DavidsPineapples : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___08_DavidsPineapples(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "PkgkKyCF8UuI2e3EnwRcMg/QDQwUd8TiUahdaOfJyUPOw", DisplayName = "08_DavidsPineapples", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _MsPaint._Home._CondimentRegion
    {
        public class ___09_DavidsJalapeno : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___09_DavidsJalapeno(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "PkgkKyCF8UuI2e3EnwRcMg/EG31BfSkQUyA-5p1WOKFkA", DisplayName = "09_DavidsJalapeno", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _MsPaint._Home._CondimentRegion
    {
        public class ___10_DavidsSpecialSauce : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___10_DavidsSpecialSauce(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "PkgkKyCF8UuI2e3EnwRcMg/FvE-FSMyTkmcxRYOpgx7YQ", DisplayName = "10_DavidsSpecialSauce", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _MsPaint._Home
    {
        public class __CondimentRegion : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __CondimentRegion(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "PkgkKyCF8UuI2e3EnwRcMg/ZPhsqq4ClUWaIiOcM9k1Vg", DisplayName = "CondimentRegion", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
                _01_DavidsCheese = new _Implementation._MsPaint._Home._CondimentRegion.___01_DavidsCheese(screenDescriptor, this);
                _02_DavidsKetchup = new _Implementation._MsPaint._Home._CondimentRegion.___02_DavidsKetchup(screenDescriptor, this);
                _03_DavidsRelish = new _Implementation._MsPaint._Home._CondimentRegion.___03_DavidsRelish(screenDescriptor, this);
                _04_DavidsMustard = new _Implementation._MsPaint._Home._CondimentRegion.___04_DavidsMustard(screenDescriptor, this);
                _05_DavidsBbq = new _Implementation._MsPaint._Home._CondimentRegion.___05_DavidsBbq(screenDescriptor, this);
                _06_DavidsBananaPeppers = new _Implementation._MsPaint._Home._CondimentRegion.___06_DavidsBananaPeppers(screenDescriptor, this);
                _07_DavidsPickedRedOnion = new _Implementation._MsPaint._Home._CondimentRegion.___07_DavidsPickedRedOnion(screenDescriptor, this);
                _08_DavidsPineapples = new _Implementation._MsPaint._Home._CondimentRegion.___08_DavidsPineapples(screenDescriptor, this);
                _09_DavidsJalapeno = new _Implementation._MsPaint._Home._CondimentRegion.___09_DavidsJalapeno(screenDescriptor, this);
                _10_DavidsSpecialSauce = new _Implementation._MsPaint._Home._CondimentRegion.___10_DavidsSpecialSauce(screenDescriptor, this);
            }

            public _Implementation._MsPaint._Home._CondimentRegion.___01_DavidsCheese _01_DavidsCheese { get; private set; }

            public _Implementation._MsPaint._Home._CondimentRegion.___02_DavidsKetchup _02_DavidsKetchup { get; private set; }

            public _Implementation._MsPaint._Home._CondimentRegion.___03_DavidsRelish _03_DavidsRelish { get; private set; }

            public _Implementation._MsPaint._Home._CondimentRegion.___04_DavidsMustard _04_DavidsMustard { get; private set; }

            public _Implementation._MsPaint._Home._CondimentRegion.___05_DavidsBbq _05_DavidsBbq { get; private set; }

            public _Implementation._MsPaint._Home._CondimentRegion.___06_DavidsBananaPeppers _06_DavidsBananaPeppers { get; private set; }

            public _Implementation._MsPaint._Home._CondimentRegion.___07_DavidsPickedRedOnion _07_DavidsPickedRedOnion { get; private set; }

            public _Implementation._MsPaint._Home._CondimentRegion.___08_DavidsPineapples _08_DavidsPineapples { get; private set; }

            public _Implementation._MsPaint._Home._CondimentRegion.___09_DavidsJalapeno _09_DavidsJalapeno { get; private set; }

            public _Implementation._MsPaint._Home._CondimentRegion.___10_DavidsSpecialSauce _10_DavidsSpecialSauce { get; private set; }
        }
    }

    namespace _MsPaint._Home
    {
        public class __OrderDisplayRegion : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __OrderDisplayRegion(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "PkgkKyCF8UuI2e3EnwRcMg/p77CnxAo9ECJtxaQapf3iQ", DisplayName = "OrderDisplayRegion", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _MsPaint
    {
        public class __Home : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Home()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "PkgkKyCF8UuI2e3EnwRcMg/R4rb4AIfNkSV0NilkWD09g", DisplayName = "Home", Screen = this};
                BunRegion = new _Implementation._MsPaint._Home.__BunRegion(this, null);
                CondimentRegion = new _Implementation._MsPaint._Home.__CondimentRegion(this, null);
                OrderDisplayRegion = new _Implementation._MsPaint._Home.__OrderDisplayRegion(this, null);
            }

            public _Implementation._MsPaint._Home.__BunRegion BunRegion { get; private set; }

            public _Implementation._MsPaint._Home.__CondimentRegion CondimentRegion { get; private set; }

            public _Implementation._MsPaint._Home.__OrderDisplayRegion OrderDisplayRegion { get; private set; }
        }
    }

    namespace _MsPaint._PinPad._Nums
    {
        public class ___1One : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___1One(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "PkgkKyCF8UuI2e3EnwRcMg/UZJZqxrp5EWoq3hV79edbg", DisplayName = "1One", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _MsPaint._PinPad._Nums
    {
        public class ___2Two : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___2Two(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "PkgkKyCF8UuI2e3EnwRcMg/0wBAHFEanUy-2ZK57ke-lw", DisplayName = "2Two", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _MsPaint._PinPad._Nums
    {
        public class ___5Five : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___5Five(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "PkgkKyCF8UuI2e3EnwRcMg/PirfCcLfXE-txOQgHweAXA", DisplayName = "5Five", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _MsPaint._PinPad._Nums
    {
        public class ___9Nine : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___9Nine(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "PkgkKyCF8UuI2e3EnwRcMg/2Ypdz5WMBkigZCXhKCw9Ig", DisplayName = "9Nine", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _MsPaint._PinPad
    {
        public class __Nums : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Nums(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "PkgkKyCF8UuI2e3EnwRcMg/EiEg3vWCDE-wuFlNCgkuCw", DisplayName = "Nums", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
                _1One = new _Implementation._MsPaint._PinPad._Nums.___1One(screenDescriptor, this);
                _2Two = new _Implementation._MsPaint._PinPad._Nums.___2Two(screenDescriptor, this);
                _5Five = new _Implementation._MsPaint._PinPad._Nums.___5Five(screenDescriptor, this);
                _9Nine = new _Implementation._MsPaint._PinPad._Nums.___9Nine(screenDescriptor, this);
            }

            public _Implementation._MsPaint._PinPad._Nums.___1One _1One { get; private set; }

            public _Implementation._MsPaint._PinPad._Nums.___2Two _2Two { get; private set; }

            public _Implementation._MsPaint._PinPad._Nums.___5Five _5Five { get; private set; }

            public _Implementation._MsPaint._PinPad._Nums.___9Nine _9Nine { get; private set; }
        }
    }

    namespace _MsPaint
    {
        public class __PinPad : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __PinPad()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "PkgkKyCF8UuI2e3EnwRcMg/6jL-GyMYekisKyjv8AIU7A", DisplayName = "PinPad", Screen = this};
                Nums = new _Implementation._MsPaint._PinPad.__Nums(this, null);
            }

            public _Implementation._MsPaint._PinPad.__Nums Nums { get; private set; }
        }
    }

    namespace _MsPaint._Universal
    {
        public class __File : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __File(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "PkgkKyCF8UuI2e3EnwRcMg/Y6dFCjV1_kqEwYmZ2GQREw", DisplayName = "File", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _MsPaint
    {
        public class __Universal : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Universal()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "PkgkKyCF8UuI2e3EnwRcMg/kLctNo-aqEOEY6fP9qYJ5w", DisplayName = "Universal", Screen = this};
                File = new _Implementation._MsPaint._Universal.__File(this, null);
            }

            public _Implementation._MsPaint._Universal.__File File { get; private set; }
        }
    }
}