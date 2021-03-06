﻿using CrossLite;
using CrossLite.CodeFirst;

namespace ATSEngineTool.Database
{
    /// <summary>
    /// This entity represents a suitability between an <see cref="Database.Engine"/>
    /// and a <see cref="Database.Transmission"/>
    /// </summary>
    [Table]
    public class SuitableAccessory
    {
        /// <summary>
        /// Gets or sets the Engine Id for this <see cref="SuitableAccessory"/>
        /// </summary>
        [Column, Required, PrimaryKey]
        public int EngineId { get; set; }

        /// <summary>
        /// Gets or sets the Transmission Id for this <see cref="SuitableAccessory"/>
        /// </summary>
        [Column, Required, PrimaryKey]
        public int TransmissionId { get; set; }

        #region Foreign Key Properties

        /// <summary>
        /// Gets or Sets the <see cref="ATSEngineTool.Database.Engine"/> that 
        /// this truck will use in game.
        /// </summary>
        public Engine Engine
        {
            get
            {
                return FK_Engine?.Fetch();
            }
            set
            {
                EngineId = value.Id;
                FK_Engine?.Refresh();
            }
        }

        /// <summary>
        /// Gets or Sets the <see cref="ATSEngineTool.Database.Transmission"/> that 
        /// this truck will use in game.
        /// </summary>
        public Transmission Transmission
        {
            get
            {
                return FK_Transmission?.Fetch();
            }
            set
            {
                TransmissionId = value.Id;
                FK_Transmission?.Refresh();
            }
        }

        #endregion

        #region Virtual Foreign Keys

        [InverseKey("Id")]
        [ForeignKey("EngineId", 
            OnDelete = ReferentialIntegrity.Cascade,
            OnUpdate = ReferentialIntegrity.Cascade
        )]
        protected virtual ForeignKey<Engine> FK_Engine { get; set; }

        [InverseKey("Id")]
        [ForeignKey("TransmissionId",
            OnDelete = ReferentialIntegrity.Cascade,
            OnUpdate = ReferentialIntegrity.Cascade
        )]
        protected virtual ForeignKey<Transmission> FK_Transmission { get; set; }

        #endregion
    }
}
