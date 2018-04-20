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

namespace RanorexPOC
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the RanorexPOCRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
    [RepositoryFolder("d2e422e7-0921-4e37-bc3e-ebb3d763a238")]
    public partial class RanorexPOCRepository : RepoGenBaseFolder
    {
        static RanorexPOCRepository instance = new RanorexPOCRepository();

        /// <summary>
        /// Gets the singleton class instance representing the RanorexPOCRepository element repository.
        /// </summary>
        [RepositoryFolder("d2e422e7-0921-4e37-bc3e-ebb3d763a238")]
        public static RanorexPOCRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public RanorexPOCRepository() 
            : base("RanorexPOCRepository", "/", null, 0, false, "d2e422e7-0921-4e37-bc3e-ebb3d763a238", ".\\RepositoryImages\\RanorexPOCRepositoryd2e422e7.rximgres")
        {
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("d2e422e7-0921-4e37-bc3e-ebb3d763a238")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
    public partial class RanorexPOCRepositoryFolders
    {
    }
#pragma warning restore 0436
}