﻿using System;
using System.Collections.Generic;

namespace behaviac
{
	// Token: 0x02001E3A RID: 7738
	[GeneratedTypeMetaInfo]
	internal class Action_bt_APC_APC_Xiuluo_Action_node18 : Action
	{
		// Token: 0x06012622 RID: 75298 RVA: 0x0055F084 File Offset: 0x0055D484
		public Action_bt_APC_APC_Xiuluo_Action_node18()
		{
			this.m_resultOption = EBTStatus.BT_SUCCESS;
			this.method_p0 = new List<Input>();
			this.method_p0.Capacity = 6;
			Input item = default(Input);
			item.delay = 0;
			item.moveInSkillState = false;
			item.moveKeepDistance = 0;
			item.PKRobotComboCheck = false;
			item.pressTime = 0;
			item.randomChangeDirection = false;
			item.skillID = 7096;
			item.specialChoice = 0;
			this.method_p0.Add(item);
			Input item2 = default(Input);
			item2.delay = 250;
			item2.moveInSkillState = false;
			item2.moveKeepDistance = 0;
			item2.PKRobotComboCheck = false;
			item2.pressTime = 0;
			item2.randomChangeDirection = false;
			item2.skillID = 7093;
			item2.specialChoice = 0;
			this.method_p0.Add(item2);
			Input item3 = default(Input);
			item3.delay = 250;
			item3.moveInSkillState = false;
			item3.moveKeepDistance = 0;
			item3.PKRobotComboCheck = false;
			item3.pressTime = 0;
			item3.randomChangeDirection = false;
			item3.skillID = 7094;
			item3.specialChoice = 0;
			this.method_p0.Add(item3);
			Input item4 = default(Input);
			item4.delay = 250;
			item4.moveInSkillState = false;
			item4.moveKeepDistance = 0;
			item4.PKRobotComboCheck = false;
			item4.pressTime = 0;
			item4.randomChangeDirection = false;
			item4.skillID = 7095;
			item4.specialChoice = 0;
			this.method_p0.Add(item4);
			Input item5 = default(Input);
			item5.delay = 250;
			item5.moveInSkillState = false;
			item5.moveKeepDistance = 0;
			item5.PKRobotComboCheck = false;
			item5.pressTime = 0;
			item5.randomChangeDirection = false;
			item5.skillID = 7096;
			item5.specialChoice = 0;
			this.method_p0.Add(item5);
			Input item6 = default(Input);
			item6.delay = 300;
			item6.moveInSkillState = false;
			item6.moveKeepDistance = 0;
			item6.PKRobotComboCheck = false;
			item6.pressTime = 0;
			item6.randomChangeDirection = false;
			item6.skillID = 7097;
			item6.specialChoice = 0;
			this.method_p0.Add(item6);
			this.method_p1 = false;
		}

		// Token: 0x06012623 RID: 75299 RVA: 0x0055F2E2 File Offset: 0x0055D6E2
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			((BTAgent)pAgent).Action_DoAction(ref this.method_p0, this.method_p1);
			return EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400C009 RID: 49161
		private List<Input> method_p0;

		// Token: 0x0400C00A RID: 49162
		private bool method_p1;
	}
}
