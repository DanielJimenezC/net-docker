using System;
using System.Collections.Generic;
using System.Data;
using luzdelsur.web.business.Models;
using luzdelsur.web.domain;

namespace luzdelsur.web.business
{
    public class BoProject
    {
        public BoProject()
        {
        }

        public List<ProjectDto> GetProjects()
        {
            List<ProjectDto> projects;
            try
            {
                DoProject doProject = new DoProject();
                projects = new List<ProjectDto>();
                var dataTable = doProject.GetProjects();

                foreach(DataRow row in dataTable.Rows)
                {
                    ProjectDto project = new ProjectDto();
                    project.Id = row["Id"].ToString().ToString().Trim();
                    project.Name = row["Name"].ToString().ToString().Trim();
                    project.Supervisor = row["Supervisor"].ToString().ToString().Trim();
                    project.Business = row["Business"].ToString().ToString().Trim();
                    project.Domain = row["Domain"].ToString().ToString().Trim();
                    project.CreatedAt = row["CreatedAt"].ToString().ToString().Trim();

                    projects.Add(project);
                }

                return projects;

            } catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
