﻿using System;

namespace behaviac
{
	// Token: 0x02003A72 RID: 14962
	[GeneratedTypeMetaInfo]
	internal class Condition_bt_Monster_AI_Tuanben_KexilaXianshi_Boss_ACTION_node74 : Condition
	{
		// Token: 0x06015CAD RID: 89261 RVA: 0x006949FB File Offset: 0x00692DFB
		public Condition_bt_Monster_AI_Tuanben_KexilaXianshi_Boss_ACTION_node74()
		{
			this.opl_p0 = BE_Target.Self;
			this.opl_p1 = BE_Equal.NotEqual;
			this.opl_p2 = 570105;
		}

		// Token: 0x06015CAE RID: 89262 RVA: 0x00694A1C File Offset: 0x00692E1C
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((BTAgent)pAgent).Condition_CheckHasBuff(this.opl_p0, this.opl_p1, this.opl_p2);
			bool flag2 = true;
			bool flag3 = flag == flag2;
			return (!flag3) ? EBTStatus.BT_FAILURE : EBTStatus.BT_SUCCESS;
		}

		// Token: 0x0400F5E5 RID: 62949
		private BE_Target opl_p0;

		// Token: 0x0400F5E6 RID: 62950
		private BE_Equal opl_p1;

		// Token: 0x0400F5E7 RID: 62951
		private int opl_p2;
	}
}
