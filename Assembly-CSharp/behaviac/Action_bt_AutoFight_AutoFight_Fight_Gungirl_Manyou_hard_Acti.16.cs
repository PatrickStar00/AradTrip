﻿using System;
using System.Collections.Generic;

namespace behaviac
{
	// Token: 0x02002031 RID: 8241
	[GeneratedTypeMetaInfo]
	internal class Action_bt_AutoFight_AutoFight_Fight_Gungirl_Manyou_hard_Action_node40 : Action
	{
		// Token: 0x060129FD RID: 76285 RVA: 0x00575E68 File Offset: 0x00574268
		public Action_bt_AutoFight_AutoFight_Fight_Gungirl_Manyou_hard_Action_node40()
		{
			this.m_resultOption = EBTStatus.BT_SUCCESS;
			this.method_p0 = new List<Input>();
			this.method_p0.Capacity = 4;
			Input item = default(Input);
			item.delay = 0;
			item.moveInSkillState = false;
			item.moveKeepDistance = 0;
			item.PKRobotComboCheck = false;
			item.pressTime = 0;
			item.randomChangeDirection = false;
			item.skillID = 2519;
			item.specialChoice = 0;
			this.method_p0.Add(item);
			Input item2 = default(Input);
			item2.delay = 1300;
			item2.moveInSkillState = false;
			item2.moveKeepDistance = 0;
			item2.PKRobotComboCheck = false;
			item2.pressTime = 0;
			item2.randomChangeDirection = false;
			item2.skillID = 2509;
			item2.specialChoice = 0;
			this.method_p0.Add(item2);
			Input item3 = default(Input);
			item3.delay = 1800;
			item3.moveInSkillState = false;
			item3.moveKeepDistance = 0;
			item3.PKRobotComboCheck = false;
			item3.pressTime = 0;
			item3.randomChangeDirection = false;
			item3.skillID = 3;
			item3.specialChoice = 0;
			this.method_p0.Add(item3);
			Input item4 = default(Input);
			item4.delay = 1500;
			item4.moveInSkillState = false;
			item4.moveKeepDistance = 0;
			item4.PKRobotComboCheck = false;
			item4.pressTime = 0;
			item4.randomChangeDirection = false;
			item4.skillID = 4;
			item4.specialChoice = 0;
			this.method_p0.Add(item4);
			this.method_p1 = false;
		}

		// Token: 0x060129FE RID: 76286 RVA: 0x00576004 File Offset: 0x00574404
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			((BTAgent)pAgent).Action_DoAction(ref this.method_p0, this.method_p1);
			return EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400C3F0 RID: 50160
		private List<Input> method_p0;

		// Token: 0x0400C3F1 RID: 50161
		private bool method_p1;
	}
}