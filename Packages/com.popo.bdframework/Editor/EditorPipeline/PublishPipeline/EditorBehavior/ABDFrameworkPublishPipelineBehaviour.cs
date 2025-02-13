﻿using System;
using BDFramework.Editor.AssetBundle;
using BDFramework.Editor.AssetGraph.Node;
using UnityEngine;

namespace BDFramework.Editor
{
    /// <summary>
    /// BDFrame的扩展生命周期
    /// </summary>
    abstract public class ABDFrameworkPublishPipelineBehaviour
    {
        #region 编译DLL

        /// <summary>
        ///一键打包时， 开始build dll
        /// </summary>
        virtual public void OnBeginBuildDLL()
        {
        }

        /// <summary>
        /// 一键打包时，结束build dll
        /// </summary>
        /// <param name="outputPath">dll输出路径</param>
        virtual public void OnEndBuildDLL(string outputPath)
        {
        }

        #endregion

        #region 打包Sqlite

        /// <summary>
        /// 一键打包时，开始导出sqlite
        /// </summary>
        virtual public void OnBeginBuildSqlite()
        {
        }

        /// <summary>
        ///  一键打包时，完成导出sqlite
        /// </summary>
        /// <param name="outputPath">dll输出路径</param>
        virtual public void OnEndBuildSqlite(string outputPath)
        {
        }

        #endregion

        #region 导表

        /// <summary>
        /// 当excel表格导出
        /// </summary>
        /// <param name="type"></param>
        virtual public void OnExportExcel(Type type)
        {
        }

        #endregion

        #region 开始打包AssetBundle

        /// <summary>
        /// 一键打包时，开始导出AssetBundle
        /// </summary>
        /// <param name="buildInfo">自定义修改buildinfo内容 进行自定义的ab输出</param>
        virtual public void OnBuildAssetBundleBegin(BuildAssetBundleParams @params, BuildInfo buildInfo)
        {
        }

        /// <summary>
        ///  一键打包时，完成导出AssetBundle
        /// </summary>
        /// <param name="outputPath">dll输出路径</param>
        virtual public void OnBuildAssetBundleEnd(BuildAssetBundleParams @params, BuildInfo buildInfo)
        {
        }

        #endregion

        #region 资源转hash,预备上传服务器

        /// <summary>
        ///  发布资源处理前
        /// </summary>
        /// <param name="platform"></param>
        /// <param name="outputPath"></param>
        /// <param name="versionNum"></param>
        virtual public void OnPublishAssetsProccessBegin(RuntimePlatform platform, string outputPath, out string versionNum)
        {
            versionNum = "0.0.1";
        }

        /// <summary>
        ///  发布资源处理后
        /// </summary>
        virtual public void OnPublishAssetsProccessEnd(RuntimePlatform platform, string outputPath)
        {
            
        }

        #endregion
    }
}
