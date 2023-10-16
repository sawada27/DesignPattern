using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class Project
    {
        public string ProjectName { get; set; }

        protected Project(string projectName)
        {
            ProjectName = projectName;
        }

        /// <summary>
        /// 需求分析
        /// </summary>
        public abstract void AnalyzeRequirement();

        /// <summary>
        /// 产品设计
        /// </summary>
        public abstract void DesignProduct();

        /// <summary>
        /// 制定计划
        /// </summary>
        public abstract void MakePlan();

        /// <summary>
        /// 任务分解
        /// </summary>
        public abstract void ScheduleTask();

        /// <summary>
        /// 进度把控
        /// </summary>
        public abstract void ControlProcess();

        /// <summary>
        /// 产品发布
        /// </summary>
        public abstract void ReleaseProduct();

        /// <summary>
        /// 后期运维
        /// </summary>
        public abstract void MaintainProduct();
    }


    public class MVCProject : Project
    {
        public MVCProject(string projectName) : base(projectName) {
            ProjectName = projectName;

        }


        

        public override void AnalyzeRequirement()
        {
            throw new NotImplementedException();
        }

        public override void ControlProcess()
        {
            throw new NotImplementedException();
        }

        public override void DesignProduct()
        {
            throw new NotImplementedException();
        }

        public override void MaintainProduct()
        {
            throw new NotImplementedException();
        }

        public override void MakePlan()
        {
            throw new NotImplementedException();
        }

        public override void ReleaseProduct()
        {
            throw new NotImplementedException();
        }

        public override void ScheduleTask()
        {
            throw new NotImplementedException();
        }
    }
}
