﻿using System;
using System.Collections.Generic;

namespace behaviac
{
	// Token: 0x02002161 RID: 8545
	[GeneratedTypeMetaInfo]
	internal class Action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_hard_Action_node20 : Action
	{
		// Token: 0x06012C53 RID: 76883 RVA: 0x00584BF0 File Offset: 0x00582FF0
		public Action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_hard_Action_node20()
		{
			this.m_resultOption = EBTStatus.BT_SUCCESS;
			this.method_p0 = new List<Input>();
			this.method_p0.Capacity = 1;
			Input item = default(Input);
			item.delay = 0;
			item.moveInSkillState = false;
			item.moveKeepDistance = 0;
			item.PKRobotComboCheck = false;
			item.pressTime = 0;
			item.randomChangeDirection = false;
			item.skillID = 1007;
			item.specialChoice = 0;
			this.method_p0.Add(item);
			this.method_p1 = false;
		}

		// Token: 0x06012C54 RID: 76884 RVA: 0x00584C80 File Offset: 0x00583080
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			((BTAgent)pAgent).Action_DoAction(ref this.method_p0, this.method_p1);
			return EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400C646 RID: 50758
		private List<Input> method_p0;

		// Token: 0x0400C647 RID: 50759
		private bool method_p1;
	}
}
