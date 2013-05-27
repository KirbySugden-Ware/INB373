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
public class SystemRoleProvider : RoleProvider
{
	public SystemRoleProvider()
	{
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
        //code to get role of user
        Student thisStudent = new Student();
        Staff thisTutor = new Staff();
        thisStudent.StudentSearch(int.Parse(username));
        if (thisStudent.GivenName != null) {
            return new string[] { "Student" };
        } else if (thisTutor.Role != null) {
            return new string[] { "Tutor" };
        }
        //return user role
        return new string[] { username };
    }

    public override string[] GetUsersInRole(string roleName) {
        throw new NotImplementedException();
    }

    public override bool IsUserInRole(string username, string roleName) {
        throw new NotImplementedException();
    }

    public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames) {
        throw new NotImplementedException();
    }

    public override bool RoleExists(string roleName) {
        throw new NotImplementedException();
    }
}