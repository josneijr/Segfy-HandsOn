

class HomeApp extends React.Component {
    render() {
        return (
            <div className="commentBox">
                Hello, world! I am a CommentBox.
      </div>
        );
    }
}

ReactDOM.render(
    <HomeApp />,
    document.getElementById('content')
);