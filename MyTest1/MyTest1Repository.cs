﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace MyTest1
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the MyTest1Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("62290542-7fbd-408e-abca-2a6a645c6134")]
    public partial class MyTest1Repository : RepoGenBaseFolder
    {
        static MyTest1Repository instance = new MyTest1Repository();
        MyTest1RepositoryFolders.MotDePasseAppFolder _motdepasse;
        MyTest1RepositoryFolders.SetupOCM9999991AppFolder _setupocm9999991;
        MyTest1RepositoryFolders.SettingsOcmAppFolder _settingsocm;
        MyTest1RepositoryFolders.ConfirmerAppFolder _confirmer;

        /// <summary>
        /// Gets the singleton class instance representing the MyTest1Repository element repository.
        /// </summary>
        [RepositoryFolder("62290542-7fbd-408e-abca-2a6a645c6134")]
        public static MyTest1Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public MyTest1Repository() 
            : base("MyTest1Repository", "/", null, 0, false, "62290542-7fbd-408e-abca-2a6a645c6134", ".\\RepositoryImages\\MyTest1Repository62290542.rximgres")
        {
            _motdepasse = new MyTest1RepositoryFolders.MotDePasseAppFolder(this);
            _setupocm9999991 = new MyTest1RepositoryFolders.SetupOCM9999991AppFolder(this);
            _settingsocm = new MyTest1RepositoryFolders.SettingsOcmAppFolder(this);
            _confirmer = new MyTest1RepositoryFolders.ConfirmerAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("62290542-7fbd-408e-abca-2a6a645c6134")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The MotDePasse folder.
        /// </summary>
        [RepositoryFolder("c0c2a5be-26ab-41db-81d7-553d2098fe04")]
        public virtual MyTest1RepositoryFolders.MotDePasseAppFolder MotDePasse
        {
            get { return _motdepasse; }
        }

        /// <summary>
        /// The SetupOCM9999991 folder.
        /// </summary>
        [RepositoryFolder("b558f58f-12ae-4ecd-8d81-a21b3cacd039")]
        public virtual MyTest1RepositoryFolders.SetupOCM9999991AppFolder SetupOCM9999991
        {
            get { return _setupocm9999991; }
        }

        /// <summary>
        /// The SettingsOcm folder.
        /// </summary>
        [RepositoryFolder("cd884911-7d43-45b3-b2cf-762317560b4b")]
        public virtual MyTest1RepositoryFolders.SettingsOcmAppFolder SettingsOcm
        {
            get { return _settingsocm; }
        }

        /// <summary>
        /// The Confirmer folder.
        /// </summary>
        [RepositoryFolder("a219ac10-e89e-4277-8a6e-14ffc39d0258")]
        public virtual MyTest1RepositoryFolders.ConfirmerAppFolder Confirmer
        {
            get { return _confirmer; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class MyTest1RepositoryFolders
    {
        /// <summary>
        /// The MotDePasseAppFolder folder.
        /// </summary>
        [RepositoryFolder("c0c2a5be-26ab-41db-81d7-553d2098fe04")]
        public partial class MotDePasseAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _passwordInfo;
            RepoItemInfo _buttonokInfo;

            /// <summary>
            /// Creates a new MotDePasse  folder.
            /// </summary>
            public MotDePasseAppFolder(RepoGenBaseFolder parentFolder) :
                    base("MotDePasse", "/form[@name='GetPassword']", parentFolder, 30000, null, true, "c0c2a5be-26ab-41db-81d7-553d2098fe04", "")
            {
                _passwordInfo = new RepoItemInfo(this, "Password", "?/?/text[@name='Password']", "?/?/text[@name='Password']", 30000, null, "d6d3edc6-4a2a-4108-864b-2abae666b2eb");
                _buttonokInfo = new RepoItemInfo(this, "ButtonOK", "?/?/button[@name='Btn_OK']", "?/?/button[@name='Btn_OK']", 30000, null, "21ef3940-2d09-4a7b-bfea-8a6695df6899");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("c0c2a5be-26ab-41db-81d7-553d2098fe04")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("c0c2a5be-26ab-41db-81d7-553d2098fe04")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Password item.
            /// </summary>
            [RepositoryItem("d6d3edc6-4a2a-4108-864b-2abae666b2eb")]
            public virtual Ranorex.Text Password
            {
                get
                {
                    return _passwordInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Password item info.
            /// </summary>
            [RepositoryItemInfo("d6d3edc6-4a2a-4108-864b-2abae666b2eb")]
            public virtual RepoItemInfo PasswordInfo
            {
                get
                {
                    return _passwordInfo;
                }
            }

            /// <summary>
            /// The ButtonOK item.
            /// </summary>
            [RepositoryItem("21ef3940-2d09-4a7b-bfea-8a6695df6899")]
            public virtual Ranorex.Button ButtonOK
            {
                get
                {
                    return _buttonokInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ButtonOK item info.
            /// </summary>
            [RepositoryItemInfo("21ef3940-2d09-4a7b-bfea-8a6695df6899")]
            public virtual RepoItemInfo ButtonOKInfo
            {
                get
                {
                    return _buttonokInfo;
                }
            }
        }

        /// <summary>
        /// The SetupOCM9999991AppFolder folder.
        /// </summary>
        [RepositoryFolder("b558f58f-12ae-4ecd-8d81-a21b3cacd039")]
        public partial class SetupOCM9999991AppFolder : RepoGenBaseFolder
        {

            /// <summary>
            /// Creates a new SetupOCM9999991  folder.
            /// </summary>
            public SetupOCM9999991AppFolder(RepoGenBaseFolder parentFolder) :
                    base("SetupOCM9999991", "/form[@name='MainForm']", parentFolder, 30000, null, true, "b558f58f-12ae-4ecd-8d81-a21b3cacd039", "")
            {
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("b558f58f-12ae-4ecd-8d81-a21b3cacd039")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("b558f58f-12ae-4ecd-8d81-a21b3cacd039")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }
        }

        /// <summary>
        /// The SettingsOcmAppFolder folder.
        /// </summary>
        [RepositoryFolder("cd884911-7d43-45b3-b2cf-762317560b4b")]
        public partial class SettingsOcmAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _quitterInfo;

            /// <summary>
            /// Creates a new SettingsOcm  folder.
            /// </summary>
            public SettingsOcmAppFolder(RepoGenBaseFolder parentFolder) :
                    base("SettingsOcm", "/contextmenu[@processname='SettingsOcm']", parentFolder, 30000, null, false, "cd884911-7d43-45b3-b2cf-762317560b4b", "")
            {
                _quitterInfo = new RepoItemInfo(this, "Quitter", "?/?/menuitem[@accessiblename='Quitter']", "?/?/menuitem[@accessiblename='Quitter']", 30000, null, "98f22941-5b1b-4703-9bea-a6d9446af925");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("cd884911-7d43-45b3-b2cf-762317560b4b")]
            public virtual Ranorex.ContextMenu Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.ContextMenu>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("cd884911-7d43-45b3-b2cf-762317560b4b")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Quitter item.
            /// </summary>
            [RepositoryItem("98f22941-5b1b-4703-9bea-a6d9446af925")]
            public virtual Ranorex.MenuItem Quitter
            {
                get
                {
                    return _quitterInfo.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The Quitter item info.
            /// </summary>
            [RepositoryItemInfo("98f22941-5b1b-4703-9bea-a6d9446af925")]
            public virtual RepoItemInfo QuitterInfo
            {
                get
                {
                    return _quitterInfo;
                }
            }
        }

        /// <summary>
        /// The ConfirmerAppFolder folder.
        /// </summary>
        [RepositoryFolder("a219ac10-e89e-4277-8a6e-14ffc39d0258")]
        public partial class ConfirmerAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _buttonouiInfo;

            /// <summary>
            /// Creates a new Confirmer  folder.
            /// </summary>
            public ConfirmerAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Confirmer", "/form[@name='none']", parentFolder, 30000, null, true, "a219ac10-e89e-4277-8a6e-14ffc39d0258", "")
            {
                _buttonouiInfo = new RepoItemInfo(this, "ButtonOui", "button[@name='Yes']", "button[@name='Yes']", 30000, null, "8f156b8e-3b1f-4d0d-84dc-57c88a07923b");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("a219ac10-e89e-4277-8a6e-14ffc39d0258")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("a219ac10-e89e-4277-8a6e-14ffc39d0258")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ButtonOui item.
            /// </summary>
            [RepositoryItem("8f156b8e-3b1f-4d0d-84dc-57c88a07923b")]
            public virtual Ranorex.Button ButtonOui
            {
                get
                {
                    return _buttonouiInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ButtonOui item info.
            /// </summary>
            [RepositoryItemInfo("8f156b8e-3b1f-4d0d-84dc-57c88a07923b")]
            public virtual RepoItemInfo ButtonOuiInfo
            {
                get
                {
                    return _buttonouiInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
