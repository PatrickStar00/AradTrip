﻿using System;
using System.Collections.Generic;

namespace behaviac
{
	// Token: 0x02002618 RID: 9752
	[GeneratedTypeMetaInfo]
	internal class Action_bt_AutoFight_AutoFight_Gunman_Manyou_Action_node66 : Action
	{
		// Token: 0x06013576 RID: 79222 RVA: 0x005C0EF0 File Offset: 0x005BF2F0
		public Action_bt_AutoFight_AutoFight_Gunman_Manyou_Action_node66()
		{
			this.m_resultOption = EBTStatus.BT_SUCCESS;
			this.method_p0 = new List<Input>();
			this.method_p0.Capacity = 3;
			Input item = default(Input);
			item.delay = 0;
			item.moveInSkillState = false;
			item.moveKeepDistance = 0;
			item.PKRobotComboCheck = false;
			item.pressTime = 0;
			item.randomChangeDirection = false;
			item.skillID = 1008;
			item.specialChoice = 0;
			this.method_p0.Add(item);
			Input item2 = default(Input);
			item2.delay = 500;
			item2.moveInSkillState = false;
			item2.moveKeepDistance = 0;
			item2.PKRobotComboCheck = false;
			item2.pressTime = 0;
			item2.randomChangeDirection = false;
			item2.skillID = 1010;
			item2.specialChoice = 0;
			this.method_p0.Add(item2);
			Input item3 = default(Input);
			item3.delay = 350;
			item3.moveInSkillState = false;
			item3.moveKeepDistance = 0;
			item3.PKRobotComboCheck = false;
			item3.pressTime = 0;
			item3.randomChangeDirection = false;
			item3.skillID = 1006;
			item3.specialChoice = 0;
			this.method_p0.Add(item3);
			this.method_p1 = false;
		}

		// Token: 0x06013577 RID: 79223 RVA: 0x005C1038 File Offset: 0x005BF438
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			((BTAgent)pAgent).Action_DoAction(ref this.method_p0, this.method_p1);
			return EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400CFC0 RID: 53184
		private List<Input> method_p0;

		// Token: 0x0400CFC1 RID: 53185
		private bool method_p1;
	}
}
