﻿using System;

namespace behaviac
{
	// Token: 0x02003768 RID: 14184
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Action_node81 : Condition
	{
		// Token: 0x060156D7 RID: 87767 RVA: 0x00676BDB File Offset: 0x00674FDB
		public Condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Action_node81()
		{
			this.opl_p0 = 21188;
		}

		// Token: 0x060156D8 RID: 87768 RVA: 0x00676BF0 File Offset: 0x00674FF0
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_CanUseSkill(this.opl_p0);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400F0A1 RID: 61601
		private int opl_p0;
	}
}
