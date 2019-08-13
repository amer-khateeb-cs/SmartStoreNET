﻿using System.Collections.Generic;
using SmartStore.Collections;
using SmartStore.Core.Domain.Customers;
using SmartStore.Core.Domain.Security;

namespace SmartStore.Services.Security
{
    /// <summary>
    /// Permission service interface.
    /// </summary>
    public partial interface IPermissionService2
    {
        /// <summary>
        /// Gets a permission.
        /// </summary>
        /// <param name="permissionId">Permission identifier.</param>
        /// <returns>Permission.</returns>
        PermissionRecord GetPermissionById(int permissionId);

        /// <summary>
        /// Gets a permission.
        /// </summary>
        /// <param name="systemName">Permission system name.</param>
        /// <returns>Permission.</returns>
        PermissionRecord GetPermissionBySystemName(string systemName);

        /// <summary>
        /// Gets all permissions.
        /// </summary>
        /// <returns>Permissions.</returns>
        IList<PermissionRecord> GetAllPermissions();

        /// <summary>
        /// Inserts a permission.
        /// </summary>
        /// <param name="permission">Permission.</param>
        void InsertPermission(PermissionRecord permission);

        /// <summary>
        /// Updates a permission.
        /// </summary>
        /// <param name="permission">Permission.</param>
        void UpdatePermission(PermissionRecord permission);

        /// <summary>
        /// Deletes a permission.
        /// </summary>
        /// <param name="permission">Permission.</param>
        void DeletePermission(PermissionRecord permission);


        /// <summary>
        /// Gets a permission role mapping.
        /// </summary>
        /// <param name="mappingId">Permission role mapping identifier.</param>
        /// <returns>Permission role mapping.</returns>
        PermissionRoleMapping GetPermissionRoleMappingById(int mappingId);

        /// <summary>
        /// Inserts a permission role mapping.
        /// </summary>
        /// <param name="mapping">Permission role mapping.</param>
        void InsertPermissionRoleMapping(PermissionRoleMapping mapping);

        /// <summary>
        /// Updates a permission role mapping.
        /// </summary>
        /// <param name="mapping">Permission role mapping.</param>
        void UpdatePermissionRoleMapping(PermissionRoleMapping mapping);

        /// <summary>
        /// Deletes a permission role mapping.
        /// </summary>
        /// <param name="mapping">Permission role mapping.</param>
        void DeletePermissionRoleMapping(PermissionRoleMapping mapping);


        /// <summary>
        /// Install permissions.
        /// </summary>
        /// <param name="permissionProvider">Permission provider.</param>
        void InstallPermissions(IPermissionProvider permissionProvider);

        /// <summary>
        /// Uninstall permissions.
        /// </summary>
        /// <param name="permissionProvider">Permission provider.</param>
        void UninstallPermissions(IPermissionProvider permissionProvider);


        /// <summary>
        /// Authorize permission.
        /// </summary>
        /// <param name="permission">Permission.</param>
        /// <returns><c>true</c> authorized otherwise <c>false</c>.</returns>
        bool Authorize(PermissionRecord permission);

        /// <summary>
        /// Authorize permission.
        /// </summary>
        /// <param name="permission">Permission.</param>
        /// <param name="customer">Customer.</param>
        /// <returns><c>true</c> authorized otherwise <c>false</c>.</returns>
        bool Authorize(PermissionRecord permission, Customer customer);

        /// <summary>
        /// Authorize permission.
        /// </summary>
        /// <param name="permissionSystemName">Permission record system name.</param>
        /// <returns><c>true</c> authorized otherwise <c>false</c>.</returns>
        bool Authorize(string permissionSystemName);

        /// <summary>
        /// Authorize permission.
        /// </summary>
        /// <param name="permissionSystemName">Permission record system name.</param>
        /// <param name="customer">Customer.</param>
        /// <returns><c>true</c> authorized otherwise <c>false</c>.</returns>
        bool Authorize(string permissionSystemName, Customer customer);


        /// <summary>
        /// Gets the permission tree for a customer role.
        /// </summary>
        /// <param name="role">Customer role.</param>
        /// <returns>Permission tree.</returns>
        TreeNode<IPermissionNode> GetPermissionTree(CustomerRole role);
    }
}
