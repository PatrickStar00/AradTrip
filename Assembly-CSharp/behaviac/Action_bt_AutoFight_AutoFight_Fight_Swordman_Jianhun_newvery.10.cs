﻿using System;
using System.Collections.Generic;

namespace behaviac
{
	// Token: 0x020022D6 RID: 8918
	[GeneratedTypeMetaInfo]
	internal class Action_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_newveryhard_Action_node29 : Action
	{
		// Token: 0x06012F27 RID: 77607 RVA: 0x00598368 File Offset: 0x00596768
		public Action_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_newveryhard_Action_node29()
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
			item.randomChangeDirection = true;
			item.skillID = 1913;
			item.specialChoice = 0;
			this.method_p0.Add(item);
			Input item2 = default(Input);
			item2.delay = 600;
			item2.moveInSkillState = false;
			item2.moveKeepDistance = 0;
			item2.PKRobotComboCheck = false;
			item2.pressTime = 0;
			item2.randomChangeDirection = false;
			item2.skillID = 1913;
			item2.specialChoice = 0;
			this.method_p0.Add(item2);
			Input item3 = default(Input);
			item3.delay = 600;
			item3.moveInSkillState = false;
			item3.moveKeepDistance = 0;
			item3.PKRobotComboCheck = false;
			item3.pressTime = 0;
			item3.randomChangeDirection = false;
			item3.skillID = 1913;
			item3.specialChoice = 0;
			this.method_p0.Add(item3);
			Input item4 = default(Input);
			item4.delay = 600;
			item4.moveInSkillState = false;
			item4.moveKeepDistance = 0;
			item4.PKRobotComboCheck = false;
			item4.pressTime = 0;
			item4.randomChangeDirection = false;
			item4.skillID = 1913;
			item4.specialChoice = 0;
			this.method_p0.Add(item4);
			this.method_p1 = false;
		}

		// Token: 0x06012F28 RID: 77608 RVA: 0x0059850C File Offset: 0x0059690C
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			((BTAgent)pAgent).Action_DoAction(ref this.method_p0, this.method_p1);
			return EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400C93D RID: 51517
		private List<Input> method_p0;

		// Token: 0x0400C93E RID: 51518
		private bool method_p1;
	}
}
