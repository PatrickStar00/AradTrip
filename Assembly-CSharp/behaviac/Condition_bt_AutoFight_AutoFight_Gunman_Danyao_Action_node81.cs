﻿using System;

namespace behaviac
{
	// Token: 0x020025E3 RID: 9699
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_AutoFight_AutoFight_Gunman_Danyao_Action_node81 : Condition
	{
		// Token: 0x0601350D RID: 79117 RVA: 0x005BDC7B File Offset: 0x005BC07B
		public Condition_bt_AutoFight_AutoFight_Gunman_Danyao_Action_node81()
		{
			this.opl_p0 = 1006;
		}

		// Token: 0x0601350E RID: 79118 RVA: 0x005BDC90 File Offset: 0x005BC090
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_CanUseSkill(this.opl_p0);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400CF52 RID: 53074
		private int opl_p0;
	}
}
