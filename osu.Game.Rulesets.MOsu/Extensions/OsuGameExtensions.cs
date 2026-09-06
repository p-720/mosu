
using System.Linq;
using osu.Framework.Graphics.Containers;
using osu.Framework.Testing;
using osu.Game.Overlays;

namespace osu.Game.Rulesets.MOsu.Extensions;

/// <summary>
/// Collect dirty logic to get target drawable from <see cref="OsuGame"/>
/// </summary>
public static class OsuGameExtensions
{
    private static Container? getBasePlacementContainer(this OsuGame game)
        => game.Children.OfType<Container>().FirstOrDefault(c => c.ChildrenOfType<WaveOverlayContainer>().Any());

    public static Container? GetWaveOverlayPlacementContainer(this OsuGame game)
    {
        return game.getBasePlacementContainer()?.Children.OfType<Container>().FirstOrDefault(c => c.Children.OfType<WaveOverlayContainer>().Any());
    }

    public static FillFlowContainer? GetToolbarContainer(this OsuGame game)
    {
        var grid = game.Toolbar.Children.OfType<GridContainer>().FirstOrDefault();

        var rightButtonContainer = grid?.Content[0][2] as Container;

        var rightButtonsFlow = rightButtonContainer?.Children.OfType<FillFlowContainer>().FirstOrDefault();

        return rightButtonsFlow;
    }
}
