﻿using UnityEditor;
using UnityEngine;

namespace BDFramework.Editor
{
    /// <summary>
    /// 按钮枚举
    /// </summary>
    public enum BDEditorGlobalMenuItemOrderEnum
    {
        //**********************基础编辑器**************************
        BDFrameworkGuid = 0,
        BDFrameworkSetting = 1,

        //**********************BuildPipeline**************************
        BuildPipeline = 50,
        BuildPackage_DLL = 52,
        BuildPackage_Assetbundle = 53,
        BuildPackage_Table_Table2Class = 54,
        BuildPackage_Table_GenSqlite = 55,
        BuildPackage_Table_Json2Sqlite = 56,
        BuildPackage_NetProtocol_Proto2Class = 57,

        //**********************PublishPipeline**************************
        PublishPipeline = 100,
        PublishPipeline_BuildAsset = 101,
        PublishPipeline_PublishPackage = 102,
        PublishPipeline_CICD = 103,

        //**********************TestPipeline**************************
        TestPepeline = 150,
        TestPepelineEditor = 151,
    }

    /// <summary>
    /// 按钮排版
    /// </summary>
    static public class MenuItems
    {
       
        public static void Open()
        {
            EditorWindow_BDFrameworkStart.Open();
        }
        // [MenuItem("BDFrameWork工具箱/---Build Pipeline----", false, (int) BDEditorGlobalMenuItemOrderEnum.BuildPipeline)]
        // static void BUILD_PIPELINE()
        // {
        // }
        //
        // [MenuItem("BDFrameWork工具箱/---Publish Pipeline----", false, (int) BDEditorGlobalMenuItemOrderEnum.PublishPipeline)]
        // static void PUBLISH_PIPELINE()
        // {
        // }
        // [MenuItem("BDFrameWork工具箱/---Test Pipeline----", false, (int) BDEditorGlobalMenuItemOrderEnum.TestPepeline)]
        // static void TEST_PIPELINE()
        // {
        // }
    }
}