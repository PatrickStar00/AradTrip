﻿using System;

namespace behaviac
{
	// Token: 0x0200214C RID: 8524
	[GeneratedTypeMetaInfo]
	internal class Action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node44 : Action
	{
		// Token: 0x06012C2A RID: 76842 RVA: 0x0058376D File Offset: 0x00581B6D
		public Action_bt_AutoFight_AutoFight_Fight_Gunman_Manyou_foolish_Action_node44()
		{
			this.m_resultOption = EBTStatus.BT_SUCCESS;
			this.method_p0 = 1204;
		}

		// Token: 0x06012C2B RID: 76843 RVA: 0x00583787 File Offset: 0x00581B87
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			((BTAgent)pAgent).Condition_CanUseSkill(this.method_p0);
			return EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400C61E RID: 50718
		private int method_p0;
	}
}
