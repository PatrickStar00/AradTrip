﻿using System;
using System.Collections.Generic;

namespace behaviac
{
	// Token: 0x020028F4 RID: 10484
	[GeneratedTypeMetaInfo]
	internal class Action_bt_AutoFight_AutoFight_Swordman_Jiandoushi_Action_node14 : Action
	{
		// Token: 0x06013B1F RID: 80671 RVA: 0x005E2644 File Offset: 0x005E0A44
		public Action_bt_AutoFight_AutoFight_Swordman_Jiandoushi_Action_node14()
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
			item.skillID = 4009;
			item.specialChoice = 0;
			this.method_p0.Add(item);
			this.method_p1 = false;
		}

		// Token: 0x06013B20 RID: 80672 RVA: 0x005E26D4 File Offset: 0x005E0AD4
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			((BTAgent)pAgent).Action_DoAction(ref this.method_p0, this.method_p1);
			return EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400D581 RID: 54657
		private List<Input> method_p0;

		// Token: 0x0400D582 RID: 54658
		private bool method_p1;
	}
}
