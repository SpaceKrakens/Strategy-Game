// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Dormanil" file="Tile.cs">
//   MIT License
//   Copyright (c) 2016 Dormanil
// </copyright>
// <summary>
//   Defines a Tile.
// </summary> 
// --------------------------------------------------------------------------------------------------------------------

namespace Assets.Scripts.Models.World
{
    using Assets.Scripts.Interfaces;

    /// <summary>
    /// Defines a Tile.
    /// </summary>
    public class Tile : ISelectable
    {
        /// <summary>
        /// The selection info.
        /// </summary>
        private readonly ISelectable selectionInfo;

        /// <summary>
        /// Initializes a new instance of the <see cref="Tile"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="description">
        /// The description.
        /// </param>
        public Tile(string name, string description)
        {
            this.selectionInfo = new SelectionInfo(name, description);
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name
        {
            get
            {
                return this.selectionInfo.Name;
            }

            set
            {
                this.selectionInfo.Name = value;
            }
        }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description
        {
            get
            {
                return this.selectionInfo.Description;
            }

            set
            {
                this.selectionInfo.Description = value;
            }
        }

        /// <summary>
        /// Gets the selection information.
        /// </summary>
        /// <returns>
        /// The <see cref="ISelectable"/>.
        /// </returns>
        public ISelectable Select()
        {
            return this.selectionInfo.Select();
        }
    }
}