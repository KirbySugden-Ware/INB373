using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using Business;
using Data;

/// <summary>
/// Summary description for SystemRoleProvider
/// </summary>
public class SystemRoleProvider : RoleProvider {
    public SystemRoleProvider() {
        //
        // TODO: Add constructor logic here
        //
    }

    public override void AddUsersToRoles(string[] usernames, string[] roleNames) {
        throw new NotImplementedException();
    }

    public override string ApplicationName {
        get {
            throw new NotImplementedException();
        }
        set {
            throw new NotImplementedException();
        }
    }

    public override void CreateRole(string roleName) {
        throw new NotImplementedException();
    }

    public override bool DeleteRole(string roleName, bool throwOnPopulatedRole) {
        throw new NotImplementedException();
    }

    public override string[] FindUsersInRole(string roleName, string usernameToMatch) {
        throw new NotImplementedException();
    }

    public override string[] GetAllRoles() {
        throw new NotImplementedException();
    }

    public override string[] GetRolesForUser(string username) {
        string role;
        try {
            Staff user = StaffList.getAStaff(int.Parse(username));
            role = user.Role;
        } catch (Exception exc) {
            Student user = Students.getAStudent(int.Parse(username));
            if (user.GivenName != null) {
                role = "Student";
            } else {
                role = "";
            }
        }
        return new string[] { role };
    }

    public override string[] GetUsersInRole(string roleName) {
        throw new NotImplementedException();
    }

    public override bool IsUserInRole(string username, string roleName) {
        return (roleName == GetRolesForUser(username)[0]);
    }

    public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames) {
        throw new NotImplementedException();
    }

    public override bool RoleExists(string roleName) {
        throw new NotImplementedException();
    }
}